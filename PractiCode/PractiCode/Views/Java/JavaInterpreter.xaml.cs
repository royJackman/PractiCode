using Newtonsoft.Json.Linq;
using PractiCode.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PractiCode.Views.Java
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JavaInterpreter : ContentPage
    {
        public JavaInterpreter()
        {
            InitializeComponent();
        }

        async void OnRunButtonClicked(object sender, EventArgs e)
        {
            Dictionary<string, object> retval = await CodeRunner.ExecuteCodeRemotely(4, "class Rextester {public static void main(String[] args){" + JavaInterpreterTextEditor.Text + "}}", string.Empty, string.Empty);
            try
            {
                if ((string)retval["Errors"] == string.Empty)
                {
                    Console.WriteLine(retval["Errors"]);
                } 
                else
                {
                    JavaInterpreterOutputLabel.Text = retval["Result"].ToString();
                }
            }
            catch(Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }

        public void OnClearButtonClicked(object sender, EventArgs e)
        {
            JavaInterpreterOutputLabel.Text = string.Empty;
        }
    }
}