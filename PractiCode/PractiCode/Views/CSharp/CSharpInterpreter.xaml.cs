using PractiCode.Models;
using PractiCode.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PractiCode.Views.CSharp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CSharpInterpreter : ContentPage, IInterpreter
    {
        public CSharpInterpreter()
        {
            InitializeComponent();
            UI.LoadLibraries((StackLayout)Interpreter.FindByName("InterpreterLibrariesStack"), Constants.CSharpLibraries);
        }
        public void OnRunButtonClicked(object sender, EventArgs e)
        {
            var editor = (Editor)Interpreter.FindByName("InterpreterTextEditor");
            var output = (Label)Interpreter.FindByName("InterpreterOutputLabel");
            var error = (Label)Interpreter.FindByName("InterpreterErrorLabel");
            var maincode = (Editor)Interpreter.FindByName("InterpreterMainEditor");
            var librarystack = (StackLayout)Interpreter.FindByName("InterpreterLibrariesStack");

            List<string> imports = UI.GetImportsFromLibraries(librarystack);
            imports.Add("namespace Rextester {public class Program {");
            string source = CodeRunner.ProgramBuilder(maincode.Text, Libraries: imports, editor.Text, "public static void Main(string[] args) {", "}}}");

            CodeRunner.ProcessRemoteCode(output, error, (int)Languages.CSharp, source, string.Empty, string.Empty);
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
            var editor = (Editor)Interpreter.FindByName("InterpreterMainEditor");
            if (editor.Text == null || editor.Text.Trim() == string.Empty)
            {
                editor.Text = "Console.WriteLine(\"Change me!\");";
            }
            else
            {
                editor.Text += "\nConsole.WriteLine(\"Change me!\");";
            }
        }
    }
}