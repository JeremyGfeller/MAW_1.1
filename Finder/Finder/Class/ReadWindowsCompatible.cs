using System;

namespace Finder.Class
{
    class ReadWindowsCompatible
    {
        public bool ReadWindowsCompatibleFile(Files files, Finder FileFinder, string CompletePath)
        {
            string text = System.IO.File.ReadAllText(CompletePath); //Return the text as one string
            
            String txt_keyWord = FileFinder.txt_keyWord.Text; //Store the value given by the user
            bool ContentCorrespond = text.ToString().ToLower().Contains(txt_keyWord.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
            return ContentCorrespond; 
        }
    }
}

