using PractiCode.Controls;
using Syncfusion.XlsIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

namespace PractiCode.Services
{
    static class UI
    {
        public enum ExamplesEncoding
        {
            empty,
            title,
            description,
            python,
            javascript,
            csharp,
            java
        }

        public static void ChangeNavbarColor(Color color)
        {
            ((NavigationPage)((MasterDetailPage)Application.Current.MainPage).Detail).BarBackgroundColor = color;
        }

        public static void LoadExamples(int language, StackLayout stack)
        {
            var assembly = Assembly.GetExecutingAssembly();

            ExcelEngine excelEngine = new ExcelEngine();
            IApplication application = excelEngine.Excel;
            application.DefaultVersion = ExcelVersion.Xlsx;

            Stream fileStream = assembly.GetManifestResourceStream(assembly.GetManifestResourceNames().Single(str => str.EndsWith("CodeExamples.xlsx")));
            IWorkbook workbook = application.Workbooks.Open(fileStream);
            IWorksheet worksheet = workbook.Worksheets["Sheet1"];

            for (var i = 1; i <= worksheet.Rows.Length; i++)
            {
                var tempView = new CodeExampleView();

                tempView.CodeExampleTitle = worksheet[i, (int)ExamplesEncoding.title].Text;
                tempView.CodeExampleSource = worksheet[i, language].Text;
                tempView.CodeExampleDescription = worksheet[i, (int)ExamplesEncoding.description].Text;

                stack.Children.Add(tempView);
            }

            fileStream.Close();
        }

        public static void LoadLibraries(StackLayout LibraryStack, List<LibraryView> libraryViews)
        {
            foreach(LibraryView library in libraryViews)
            {
                LibraryStack.Children.Add(library);
            }
        }

        public static List<string> GetImportsFromLibraries(StackLayout LibraryStack)
        {
            List<LibraryView> libraries = LibraryStack.Children.ToList().Cast<LibraryView>().ToList();
            return libraries.Where(lib => lib.LibraryActivated)
                            .Select(lib => lib.LibraryImport)
                            .ToList();
        }
    }
}
