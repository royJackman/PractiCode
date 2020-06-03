using PractiCode.Services;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PractiCode.Views.Python
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PythonExamples : ContentPage
    {
        public PythonExamples()
        {
            InitializeComponent();
            UI.LoadExamples((int)UI.ExamplesEncoding.python, ExampleStack);
        }
    }
}