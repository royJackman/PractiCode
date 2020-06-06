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
    public partial class LibraryView : ContentView
    {
        public static readonly BindableProperty LibraryNameProperty = BindableProperty.Create(nameof(LibraryName), typeof(string), typeof(LibraryView), string.Empty);

        public static readonly BindableProperty LibraryImportProperty = BindableProperty.Create(nameof(LibraryImport), typeof(string), typeof(LibraryView), string.Empty);

        public static readonly BindableProperty LibraryActivatedProperty = BindableProperty.Create(nameof(LibraryActivated), typeof(bool), typeof(LibraryView), false);

        public string LibraryName
        {
            get => (string)GetValue(LibraryView.LibraryNameProperty);
            set => SetValue(LibraryView.LibraryNameProperty, value);
        }

        public string LibraryImport
        {
            get => (string)GetValue(LibraryView.LibraryImportProperty);
            set => SetValue(LibraryView.LibraryImportProperty, value);
        }

        public bool LibraryActivated
        {
            get => (bool)GetValue(LibraryView.LibraryActivatedProperty);
            set => SetValue(LibraryView.LibraryActivatedProperty, value);
        }

        public LibraryView(string LibName = null, string LibImport = null, bool LibActivated = false)
        {
            InitializeComponent();

            if (LibName != null)
            {
                this.LibraryName = LibName;
            }

            if (LibImport != null)
            {
                this.LibraryImport = LibImport;
            }

            this.LibraryActivated = LibActivated;
        }
    }
}