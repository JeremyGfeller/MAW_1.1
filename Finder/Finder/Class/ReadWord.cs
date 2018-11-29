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

namespace Finder.Class
{
    class ReadWord
    {
        public bool ReadWordFile(Files files, Finder FileFinder, string CompletePath)
        {
            //N:\COMMUN\ELEVE\INFO\SI-T1a\MawDataTest

            bool SortResult = CompletePath.ToLower().Contains(".txt");
            bool SortResult2 = CompletePath.ToLower().Contains(".doc");
            StringBuilder text = new StringBuilder();

            if (SortResult2 || SortResult)
            {
                Document document = new Document();
                document.LoadFromFile(CompletePath);
                foreach (Section section in document.Sections)
                {
                    foreach (Paragraph paragraph in section.Paragraphs)
                    {
                        text.AppendLine(paragraph.Text);
                    }
                }
            }

            bool ContentCorrespond; //Used to know if the content correspond with the values given by the user
            String txt_keyWord = FileFinder.txt_keyWord.Text; //Store the value given by the user
            ContentCorrespond = text.ToString().ToLower().Contains(txt_keyWord.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
            return ContentCorrespond;


            //Fonctionnel lecture PDF
            /*try
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
                    bool ContentCorrespond; //Used to know if the content correspond with the values given by the user
                    String txt_keyWord = FileFinder.txt_keyWord.Text; //Store the value given by the user
                    ContentCorrespond = text.ToString().ToLower().Contains(txt_keyWord.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
                    return ContentCorrespond;
                }
            }
            catch
            {
                return false;
            }*/
        }
    }
}

