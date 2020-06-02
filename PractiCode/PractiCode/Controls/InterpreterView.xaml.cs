using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PractiCode.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InterpreterView : ContentView
    {
        public static readonly BindableProperty InterpreterEditorPlaceholderProperty = BindableProperty.Create(nameof(InterpreterEditorPlaceholder), typeof(string), typeof(InterpreterView), string.Empty);

        public string InterpreterEditorPlaceholder
        {
            get => (string)GetValue(InterpreterView.InterpreterEditorPlaceholderProperty);
            set => SetValue(InterpreterView.InterpreterEditorPlaceholderProperty, value);
        }

        public InterpreterView()
        {
            InitializeComponent();
        }
    }
}