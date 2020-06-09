using PractiCode.Controls;
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
    public partial class PythonInterpreter : ContentPage, IInterpreter
    {
        public PythonInterpreter()
        {
            InitializeComponent();
            UI.LoadLibraries((StackLayout)Interpreter.FindByName("InterpreterLibrariesStack"), Constants.PythonLibraries);
        }

        public void OnRunButtonClicked(object sender, EventArgs e)
        {
            var editor = (Editor)Interpreter.FindByName("InterpreterTextEditor");
            var output = (Label)Interpreter.FindByName("InterpreterOutputLabel");
            var error = (Label)Interpreter.FindByName("InterpreterErrorLabel");
            var librarystack = (StackLayout)Interpreter.FindByName("InterpreterLibrariesStack");

            string source = CodeRunner.ProgramBuilder(editor.Text, Libraries: UI.GetImportsFromLibraries(librarystack));
            CodeRunner.ProcessRemoteCode(output, error, (int)Languages.Python3, source, string.Empty, string.Empty);
        }

        public void OnClearButtonClicked(object sender, EventArgs e)
        {
            ((Editor)Interpreter.FindByName("InterpreterTextEditor")).Text = string.Empty;
        }

        public void SetSource(string source)
        {
            ((Editor)Interpreter.FindByName("InterpreterTextEditor")).Text = source;
        }

        public void OnAddPrintButtonClicked(object sender, EventArgs e)
        {
            var editor = (Editor)Interpreter.FindByName("InterpreterTextEditor");
            if (editor.Text == null || editor.Text.Trim() == string.Empty)
            {
                editor.Text = "print('Change me!')";
            }
            else
            {
                editor.Text += "\nprint('Change me!')";
            }
        }
    }
}