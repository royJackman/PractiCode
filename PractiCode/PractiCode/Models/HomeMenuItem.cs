using System;
using System.Collections.Generic;
using System.Text;

namespace PractiCode.Models
{
    public enum MenuItemType
    {
        Browse,
        Python,
        CSharp,
        Java,
        TypeScript
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
