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

        void OnRunButtonClicked(object sender, EventArgs e)
        {
            CodeRunner.ProcessRemoteCode(PythonInterpreterTextEditor, PythonInterpreterOutputLabel, PythonInterpreterErrorLabel, (int)Languages.Python3, PythonInterpreterTextEditor.Text, string.Empty, string.Empty);
        }

        public void OnClearButtonClicked(object sender, EventArgs e)
        {
            PythonInterpreterTextEditor.Text = string.Empty;
        }
    }
}