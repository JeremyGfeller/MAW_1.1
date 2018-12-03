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
            bool SortResult = CompletePath.ToLower().Contains(".xls");
            StringBuilder text = new StringBuilder();
            if (SortResult)
            {
                Workbook workbook = new Workbook();
                workbook.LoadFromFile(CompletePath);
                Worksheet sheet = workbook.Worksheets[0];
                int columnCount = sheet.Columns.Count();
                int rowsCount = sheet.Rows.Count();
                int i = 0;
                int j = 0;
                foreach (CellRange rows in sheet.Rows[0])
                {
                    try
                    {
                        foreach (CellRange range in sheet.Columns[0])
                        {
                            text.AppendLine(range.Text + rows.Text);

                            if (j > rowsCount)
                            {
                                break;
                            }
                            else
                            {
                                j++;
                            }
                        }
                        if (i > rowsCount)
                        {
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    catch
                    {

                    }
                    
                }
            }
            bool ContentCorrespond; //Used to know if the content correspond with the values given by the user
            String txt_keyWord = FileFinder.txt_keyWord.Text; //Store the value given by the user
            ContentCorrespond = text.ToString().ToLower().Contains(txt_keyWord.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
            return ContentCorrespond; 
        }
    }
}

