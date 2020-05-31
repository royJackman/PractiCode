using PractiCode.Models;
using PractiCode.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PractiCode.Views.Python
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PythonInterpreter : ContentPage
    {
        public PythonInterpreter()
        {
            InitializeComponent();
        }

        async void OnRunButtonClicked(object sender, EventArgs e)
        {
            Dictionary<string, object> retval = await CodeRunner.ExecuteCodeRemotely((int)MenuItemType.Python3, PythonInterpreterTextEditor.Text, string.Empty, string.Empty);
            try
            {
                if ((string)retval["Errors"] == string.Empty)
                {
                    Console.WriteLine(retval["Errors"]);
                }
                else
                {
                    PythonInterpreterOutputLabel.Text = retval["Result"].ToString();
                }
            }
            catch(Exception Ex)
            {
                Console.WriteLine(Ex.Message);
            }
        }

        public void OnClearButtonClicked(object sender, EventArgs e)
        {
            PythonInterpreterTextEditor.Text = string.Empty;
        }
    }
}