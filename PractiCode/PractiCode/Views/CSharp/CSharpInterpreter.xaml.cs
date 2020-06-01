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
    public partial class CSharpInterpreter : ContentPage
    {
        public CSharpInterpreter()
        {
            InitializeComponent();
        }
        void OnRunButtonClicked(object sender, EventArgs e)
        {
            CodeRunner.ProcessRemoteCode(CSharpInterpreterTextEditor, CSharpInterpreterOutputLabel, CSharpInterpreterErrorLabel, (int)Languages.CSharp, "using System;using System.Collections.Generic;using System.Linq;using System.Text.RegularExpressions;namespace Rextester {public class Program {public static void Main(string[] args){" + CSharpInterpreterTextEditor.Text + "}}}", string.Empty, string.Empty);
        }

        public void OnClearButtonClicked(object sender, EventArgs e)
        {
            CSharpInterpreterTextEditor.Text = string.Empty;
        }
    }
}