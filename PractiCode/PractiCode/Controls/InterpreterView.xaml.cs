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

        public static readonly BindableProperty InterpreterLibrariesProperty = BindableProperty.Create(nameof(InterpreterLibraries), typeof(bool), typeof(InterpreterView), false);

        public static readonly BindableProperty InterpreterSourceProperty = BindableProperty.Create(nameof(InterpreterSource), typeof(bool), typeof(InterpreterView), false);

        public static readonly BindableProperty InterpreterStartingStringProperty = BindableProperty.Create(nameof(InterpreterStartingString), typeof(string), typeof(InterpreterView), string.Empty);

        public static readonly BindableProperty InterpreterEndingStringProperty = BindableProperty.Create(nameof(InterpreterEndingString), typeof(string), typeof(InterpreterView), string.Empty);

        public string InterpreterEditorPlaceholder
        {
            get => (string)GetValue(InterpreterView.InterpreterEditorPlaceholderProperty);
            set => SetValue(InterpreterView.InterpreterEditorPlaceholderProperty, value);
        }

        public bool InterpreterLibraries
        {
            get => (bool)GetValue(InterpreterView.InterpreterLibrariesProperty);
            set => SetValue(InterpreterView.InterpreterLibrariesProperty, value);
        }

        public bool InterpreterSource
        {
            get => (bool)GetValue(InterpreterView.InterpreterSourceProperty);
            set => SetValue(InterpreterView.InterpreterSourceProperty, value);
        }

        public string InterpreterStartingString
        {
            get => (string)GetValue(InterpreterView.InterpreterStartingStringProperty);
            set => SetValue(InterpreterView.InterpreterStartingStringProperty, value);
        }

        public string InterpreterEndingString
        {
            get => (string)GetValue(InterpreterView.InterpreterEndingStringProperty);
            set => SetValue(InterpreterView.InterpreterEndingStringProperty, value);
        }

        public InterpreterView()
        {
            InitializeComponent();
        }
    }
}