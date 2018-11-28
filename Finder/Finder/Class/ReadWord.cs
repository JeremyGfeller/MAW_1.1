using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Spire.Doc;
using Spire.Doc.Documents;

using System.Windows;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Security.Principal;
using System.Windows.Input;

namespace Finder.Class
{
    /*class ReadWord
    {
        public bool ReadWordFile(Files files, Finder FileFinder, string CompletePath)
        {
            Microsoft.Office.Interop.Word.Application Word = new Microsoft.Office.Interop.Word.Application(); //Initialise the application

            object miss = System.Reflection.Missing.Value; //Ref for open word doc
            object readOnly = true; //Put the file in read only

            Microsoft.Office.Interop.Word.Document docs = Word.Documents.Open(CompletePath, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss); //Open application with all parameters
            string WordText = ""; //Variable to store the text in the document

            for (int i = 0; i < docs.Paragraphs.Count; i++) //Store the text of each paragraph
            {
                WordText += " \r\n " + docs.Paragraphs[i + 1].Range.Text.ToString();
            }
            docs.Close(); //Close document

            bool ContentCorrespond;
            String txt_keyWord = FileFinder.txt_keyWord.Text;
            ContentCorrespond = WordText.ToString().ToLower().Contains(txt_keyWord.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
            return ContentCorrespond;
        }
    }*/

    class ReadWord
    {
        public bool ReadWordFile(Files files, Finder FileFinder, string CompletePath, string path)
        {
            StringBuilder text = new StringBuilder();
            DirectoryInfo d = new DirectoryInfo(path);//Assuming Test is your Folder
            FileInfo[] extensionFile = d.GetFiles("*.*"); //Getting Text files

            //N:\COMMUN\ELEVE\INFO\SI-T1a\MawDataTest
            

            foreach (FileInfo file in extensionFile)
            {
                bool checkpptx = path.Contains("pptx");

                if (checkpptx == false)
                {
                    try
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
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    //MessageBox.Show(Checkpptx);
                }
            }

            bool ContentCorrespond;
            String txt_keyWord = FileFinder.txt_keyWord.Text;
            ContentCorrespond = text.ToString().ToLower().Contains(txt_keyWord.ToLower());
            //ContentCorrespond = WordText.ToString().ToLower().Contains(txt_keyWord.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
            return ContentCorrespond;
            //Create a New TXT File to Save Extracted Text
            /*File.WriteAllText("Extract.txt", sb.ToString());
	        System.Diagnostics.Process.Start("ExtractText.txt");*/
	    }
    }
}

