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

        public void OnRunButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine("Run my code");
        }

        public void OnClearButtonClicked(object sender, EventArgs e)
        {
            PyterpreterTextEntry.Text = string.Empty;
        }
    }
}