using PractiCode.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PractiCode.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = Languages.Browse, Title="Browse" },
                new HomeMenuItem {Id = Languages.Python, Title="Python", Blurb="Scripting with Snakes" },
                new HomeMenuItem {Id = Languages.CSharp, Title="C#", Blurb="A very fancy name for Java.NET" },
                new HomeMenuItem {Id = Languages.Java, Title="Java", Blurb="Still incomprehensible after 20 years" },
                new HomeMenuItem {Id = Languages.JavaScript, Title="JavaScript", Blurb="Light, messy, heavy, clean scripting" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}