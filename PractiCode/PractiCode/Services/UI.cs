using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace PractiCode.Services
{
    static class UI
    {
        public static void ChangeNavbarColor(Color color)
        {
            ((NavigationPage)((MasterDetailPage)Application.Current.MainPage).Detail).BarBackgroundColor = color;
        }
    }
}
