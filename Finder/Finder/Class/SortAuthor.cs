﻿using System;

namespace Finder.Class
{
    class SortAuthor
    {
        public bool SortAuthorName(Files files, Finder FileFinder, string CompletePath)
        {
            string author = System.IO.File.GetAccessControl(CompletePath).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString(); //Return the author of the file
            
            String AuthorName = FileFinder.txt_author.Text;
            bool IsAuthor = author.ToLower().Contains(AuthorName.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
            return IsAuthor;
        }
    }
}