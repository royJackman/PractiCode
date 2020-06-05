﻿using PractiCode.Models;
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
        }
        public void OnRunButtonClicked(object sender, EventArgs e)
        {
            var editor = (Editor)Interpreter.FindByName("InterpreterTextEditor");
            var output = (Label)Interpreter.FindByName("InterpreterOutputLabel");
            var error = (Label)Interpreter.FindByName("InterpreterErrorLabel");
            CodeRunner.ProcessRemoteCode(editor, output, error, (int)Languages.CSharp, "using System;using System.Collections.Generic;using System.Linq;using System.Text.RegularExpressions;namespace Rextester {public class Program {public static void Main(string[] args){" + editor.Text + "}}}", string.Empty, string.Empty);
        }

        public void OnClearButtonClicked(object sender, EventArgs e)
        {
            ((Editor)Interpreter.FindByName("InterpreterTextEditor")).Text = string.Empty;
        }

        public void SetSource(string source)
        {
            ((Editor)Interpreter.FindByName("InterpreterTextEditor")).Text = source;
        }
    }
}