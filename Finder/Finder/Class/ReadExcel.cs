using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Spire.Doc;
using Spire.Doc.Documents;
using Spire.Xls;
using Spire.Presentation;
using System.Windows;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Security.Principal;
using System.Windows.Input;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Spire.Xls.Core.Spreadsheet.Shapes;

namespace Finder.Class
{
    class ReadExcel
    {
        public bool ReadExcelFile(Files files, Finder FileFinder, string CompletePath)
        {
            StringBuilder text = new StringBuilder();

            Workbook workbook = new Workbook();
            workbook.LoadFromFile(CompletePath);
            Worksheet sheet = workbook.Worksheets[0];

            String txt_keyWord = FileFinder.txt_keyWord.Text; //Store the value given by the user
            foreach (CellRange range in sheet.FindAllString(txt_keyWord.ToLower(), true, true))
            {
                return true; //If the text correspond, a booleon of type true is returned
            }
            return false; //Else, a false is returned
        }
    }
}

