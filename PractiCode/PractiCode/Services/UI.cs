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
        public static void ChangeNavbarColor(Color color)
        {
            ((NavigationPage)((MasterDetailPage)Application.Current.MainPage).Detail).BarBackgroundColor = color;
        }

        public static void LoadExamples(string language, StackLayout stack)
        {
            var assembly = Assembly.GetExecutingAssembly();

            ExcelEngine excelEngine = new ExcelEngine();
            IApplication application = excelEngine.Excel;
            application.DefaultVersion = ExcelVersion.Xlsx;

            Stream fileStream = assembly.GetManifestResourceStream(assembly.GetManifestResourceNames().Single(str => str.EndsWith("CodeExamples.xlsx")));
            IWorkbook workbook = application.Workbooks.Open(fileStream);
            IWorksheet worksheet = workbook.Worksheets[language];

            for (var i = 1; i <= worksheet.Rows.Length; i++)
            {
                var tempView = new CodeExampleView();

                tempView.CodeExampleTitle = worksheet[i, 1].Text;
                tempView.CodeExampleSource = worksheet[i, 2].Text;
                tempView.CodeExampleDescription = worksheet[i, 3].Text;

                stack.Children.Add(tempView);
            }

            fileStream.Close();
        }
    }
}
