using PractiCode.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace PractiCode.Services
{
    public static class Constants
    {
        public static List<LibraryView> PythonLibraries = new List<LibraryView>()
        {
            new LibraryView("Math", "import math"),
            new LibraryView("Time", "import time"),
            new LibraryView("JSON", "import json"),
            new LibraryView("Sys", "import sys"),
            new LibraryView("OS", "import os")
        };

        public static List<LibraryView> CSharpLibraries = new List<LibraryView>()
        {
            new LibraryView("System", "using System;", true),
            new LibraryView("Generic Collections", "using System.Collections.Generic;", true),
            new LibraryView("Text", "using System.Text;"),
            new LibraryView("Linq", "using System.Linq;", true)
        };

        public static List<LibraryView> JavaLibraries = new List<LibraryView>()
        {
            new LibraryView("Scanner", "import java.util.Scanner;"),
            new LibraryView("ArrayList", "import java.util.ArrayList;")
        };
    }
}
