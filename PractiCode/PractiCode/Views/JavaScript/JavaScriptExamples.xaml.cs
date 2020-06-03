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
    public partial class JavaScriptExamples : ContentPage
    {
        public JavaScriptExamples()
        {
            InitializeComponent();
            UI.LoadExamples((int)UI.ExamplesEncoding.javascript, ExampleStack);
        }
    }
}