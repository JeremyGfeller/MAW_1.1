using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Text;

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

            String txt_keyWord = FileFinder.txt_keyWord.Text; //Store the value given by the user
            bool ContentCorrespond = text.ToString().ToLower().Contains(txt_keyWord.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
            return ContentCorrespond;
        }
    }
}

