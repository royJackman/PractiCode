using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PractiCode.Services
{
    static class CodeRunner
    {
        private static readonly HttpClient client = new HttpClient();
        public static string PaizaBaseUrl = "https://api.paiza.io/runners/";
        public static string HackerEarthRunUrl = "https://api.hackerearth.com/code/run/";

        public static async Task<Dictionary<string, object>> ExexuteCodeRemotely(string source, string lang, bool async, int time_limit)
        {
            var values = new Dictionary<string, string>
            {
                { "client_secret", Credentials.hackerearth_api_key },
                { "async", async ? "1" : "0" },
                { "source", source },
                { "lang", lang },
                { "time_limit", time_limit.ToString() },
                { "memory_limit", "262144" }
            };
            var content = new FormUrlEncodedContent(values);
            var response = await client.PostAsync(HackerEarthRunUrl, content);
            var responseString = await response.Content.ReadAsStringAsync();
            return await Task.FromResult(JsonConvert.DeserializeObject<Dictionary<string, object>>(responseString));
        }
    }
}
