﻿using Newtonsoft.Json.Linq;
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
    public partial class JavaInterpreter : ContentPage, IInterpreter
    {
        public JavaInterpreter()
        {
            InitializeComponent();
            UI.LoadLibraries((StackLayout)Interpreter.FindByName("InterpreterLibrariesStack"), Constants.JavaLibraries);
        }

        public void OnRunButtonClicked(object sender, EventArgs e)
        {
            var editor = (Editor)Interpreter.FindByName("InterpreterTextEditor");
            var output = (Label)Interpreter.FindByName("InterpreterOutputLabel");
            var error = (Label)Interpreter.FindByName("InterpreterErrorLabel");
            var maincode = (Editor)Interpreter.FindByName("InterpreterMainEditor");
            var librarystack = (StackLayout)Interpreter.FindByName("InterpreterLibrariesStack");

            List<string> imports = UI.GetImportsFromLibraries(librarystack);
            imports.Add("class Rextester {");
            string source = CodeRunner.ProgramBuilder(maincode.Text, Libraries: imports, editor.Text, "public static void main(String[] args){", "}}");

            CodeRunner.ProcessRemoteCode(output, error, (int)Languages.Java, source, string.Empty, string.Empty);
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
                editor.Text = "System.out.println(\"Change me!\");";
            }
            else
            {
                editor.Text += "\nSystem.out.println(\"Change me!\");";
            }
        }
    }
}