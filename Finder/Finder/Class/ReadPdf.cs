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
    class ReadPdf
    {
        public bool ReadPdfFile(Files files, Finder FileFinder, string CompletePath)
        {
            using (PdfReader reader = new PdfReader(CompletePath))
            {
                StringBuilder text = new StringBuilder();

                bool SortResult = CompletePath.ToLower().Contains(".pdf");

                if (SortResult)
                {

                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                    }
                }

                String txt_keyWord = FileFinder.txt_keyWord.Text; //Store the value given by the user
                bool ContentCorrespond = text.ToString().ToLower().Contains(txt_keyWord.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
                return ContentCorrespond;
            }
        }
    }
}

