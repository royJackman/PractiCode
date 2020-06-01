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
    public partial class LanguageNavbarView : ContentView
    {
        public static readonly BindableProperty LanguageNavbarNameProperty = BindableProperty.Create(nameof(LanguageNavbarName), typeof(string), typeof(LanguageNavbarView), string.Empty);
        public static readonly BindableProperty LanguageNavbarVersionProperty = BindableProperty.Create(nameof(LanguageNavbarVersion), typeof(string), typeof(LanguageNavbarView), string.Empty);
        public static readonly BindableProperty LanguageNavbarTextColorProperty = BindableProperty.Create(nameof(LanguageNavbarTextColor), typeof(string), typeof(LanguageNavbarView), "White");
        public static readonly BindableProperty LanguageNavbarImageProperty = BindableProperty.Create(nameof(LanguageNavbarImage), typeof(string), typeof(LanguageNavbarView), string.Empty);


        public string LanguageNavbarName
        {
            get => (string)GetValue(LanguageNavbarView.LanguageNavbarNameProperty);
            set => SetValue(LanguageNavbarView.LanguageNavbarNameProperty, value);
        }

        public string LanguageNavbarVersion
        {
            get => (string)GetValue(LanguageNavbarView.LanguageNavbarVersionProperty);
            set => SetValue(LanguageNavbarView.LanguageNavbarVersionProperty, value);
        }

        public string LanguageNavbarTextColor
        {
            get => (string)GetValue(LanguageNavbarView.LanguageNavbarTextColorProperty);
            set => SetValue(LanguageNavbarView.LanguageNavbarTextColorProperty, value);
        }

        public string LanguageNavbarImage
        {
            get => (string)GetValue(LanguageNavbarView.LanguageNavbarImageProperty);
            set => SetValue(LanguageNavbarView.LanguageNavbarImageProperty, value);
        }

        public LanguageNavbarView()
        {
            InitializeComponent();
        }
    }
}