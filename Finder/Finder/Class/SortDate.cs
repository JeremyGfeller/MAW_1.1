using System;
using System.IO;

namespace Finder.Class
{
    class SortDate
    {
        public bool SortDateModification(Files files, Finder FileFinder, string CompletePath)
        {
            DateTime GetDateCreation = File.GetLastWriteTime(CompletePath); //Return the date of the last modification of the file
            
            String DateTimeGiven = FileFinder.txt_date.Text; //Store the value given by the user
            string DateCreationInString = GetDateCreation.ToString(); //Store the date in a string
            string DateCreation = DateTime.Parse(DateCreationInString).ToString("dd.MM.yyyy"); //Change the format of the date
            bool DateCorresponds = DateCreation.Contains(DateTimeGiven.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
            return DateCorresponds;
        }
    }
}
