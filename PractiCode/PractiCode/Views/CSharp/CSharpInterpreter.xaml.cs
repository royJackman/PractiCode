﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PractiCode.Views.CSharp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CSharpInterpreter : ContentPage
    {
        public CSharpInterpreter()
        {
            InitializeComponent();
        }
    }
}