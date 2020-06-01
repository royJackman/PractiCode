using Newtonsoft.Json.Linq;
using PractiCode.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PractiCode.Models;

namespace PractiCode.Views.Java
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JavaInterpreter : ContentPage
    {
        public JavaInterpreter()
        {
            InitializeComponent();
        }

        void OnRunButtonClicked(object sender, EventArgs e)
        {
            CodeRunner.ProcessRemoteCode(JavaInterpreterTextEditor, JavaInterpreterOutputLabel, JavaInterpreterErrorLabel, (int)Languages.Java, "class Rextester {public static void main(String[] args){" + JavaInterpreterTextEditor.Text + "}}", string.Empty, string.Empty);
        }

        public void OnClearButtonClicked(object sender, EventArgs e)
        {
            JavaInterpreterOutputLabel.Text = string.Empty;
        }
    }
}