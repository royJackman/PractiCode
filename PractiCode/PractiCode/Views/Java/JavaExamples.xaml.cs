using PractiCode.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PractiCode.Views.Java
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class JavaExamples : ContentPage
    {
        public JavaExamples()
        {
            InitializeComponent();
            UI.LoadExamples((int)UI.ExamplesEncoding.java, ExampleStack);
        }
    }
}