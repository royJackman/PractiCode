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
    public partial class CSharpExamples : ContentPage
    {
        public CSharpExamples()
        {
            InitializeComponent();
            UI.LoadExamples((int)UI.ExamplesEncoding.csharp, ExampleStack);
        }
    }
}