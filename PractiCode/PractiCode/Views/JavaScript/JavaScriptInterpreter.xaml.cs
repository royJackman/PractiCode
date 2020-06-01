using PractiCode.Models;
using PractiCode.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PractiCode.Views.JavaScript
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JavaScriptInterpreter : ContentPage
    {
        public JavaScriptInterpreter()
        {
            InitializeComponent();
        }

        void OnRunButtonClicked(object sender, EventArgs e)
        {
            CodeRunner.ProcessRemoteCode(JavaScriptInterpreterTextEditor, JavaScriptInterpreterOutputLabel, JavaScriptInterpreterErrorLabel, (int)Languages.JavaScript, JavaScriptInterpreterTextEditor.Text, string.Empty, string.Empty);
        }

        public void OnClearButtonClicked(object sender, EventArgs e)
        {
            JavaScriptInterpreterTextEditor.Text = string.Empty;
        }
    }
}