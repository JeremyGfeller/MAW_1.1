using System;

namespace Finder.Class
{
    class SortFilename
    {
        public bool SortFilenameString(Files files, Finder FileFinder, string CompletePath)
        {
            string Filename = System.IO.Path.GetFileName(CompletePath); //Return the name + extension of the file
            
            String FilenameGiven = FileFinder.txt_file.Text; //Store the value given by the user
            bool FilenameCorresponds = Filename.ToLower().Contains(FilenameGiven.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
            return FilenameCorresponds;
        }
    }
}
