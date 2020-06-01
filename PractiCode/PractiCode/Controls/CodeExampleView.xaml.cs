using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PractiCode.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    [DesignTimeVisible(true)]
    public partial class CodeExampleView : ContentView
    {
        public static readonly BindableProperty CodeExampleTitleProperty = BindableProperty.Create(nameof(CodeExampleTitle), typeof(string), typeof(CodeExampleView), string.Empty);
        public static readonly BindableProperty CodeExampleDescriptionProperty = BindableProperty.Create(nameof(CodeExampleDescription), typeof(string), typeof(CodeExampleView), string.Empty);
        public static readonly BindableProperty CodeExampleSourceProperty = BindableProperty.Create(nameof(CodeExampleSource), typeof(string), typeof(CodeExampleView), string.Empty);

        public string CodeExampleTitle
        {
            get => (string)GetValue(CodeExampleView.CodeExampleTitleProperty);
            set => SetValue(CodeExampleView.CodeExampleTitleProperty, value);
        }

        public string CodeExampleDescription
        {
            get => (string)GetValue(CodeExampleView.CodeExampleDescriptionProperty);
            set => SetValue(CodeExampleView.CodeExampleDescriptionProperty, value);
        }

        public string CodeExampleSource
        {
            get => (string)GetValue(CodeExampleView.CodeExampleSourceProperty);
            set => SetValue(CodeExampleView.CodeExampleSourceProperty, value);
        }

        public CodeExampleView()
        {
            InitializeComponent();
        }
    }
}