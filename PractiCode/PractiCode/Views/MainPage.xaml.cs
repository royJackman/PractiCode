using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using PractiCode.Models;
using PractiCode.ViewModels;
using PractiCode.Views.Python;
using PractiCode.Views.CSharp;
using PractiCode.Views.Java;
using PractiCode.Views.JavaScript;

namespace PractiCode.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)Languages.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)Languages.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)Languages.Python:
                        MenuPages.Add(id, new NavigationPage(new PythonMain()));
                        break;
                    case (int)Languages.CSharp:
                        MenuPages.Add(id, new NavigationPage(new CSharpMain()));
                        break;
                    case (int)Languages.Java:
                        MenuPages.Add(id, new NavigationPage(new JavaMain()));
                        break;
                    case (int)Languages.JavaScript:
                        MenuPages.Add(id, new NavigationPage(new JavaScriptMain()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}