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
    class ReadWord
    {
        public bool ReadWordFile(Files files, Finder FileFinder, string CompletePath)
        {
            StringBuilder text = new StringBuilder();
            
                Document document = new Document();
                document.LoadFromFile(CompletePath);
                foreach (Section section in document.Sections)
                {
                    foreach (Paragraph paragraph in section.Paragraphs)
                    {
                        text.AppendLine(paragraph.Text);
                    }
                }

            bool ContentCorrespond; //Used to know if the content correspond with the values given by the user
            String txt_keyWord = FileFinder.txt_keyWord.Text; //Store the value given by the user
            ContentCorrespond = text.ToString().ToLower().Contains(txt_keyWord.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
            return ContentCorrespond;
        }
    }
}

