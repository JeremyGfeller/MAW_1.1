using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Finder.Class
{
    class Files
    {
        public void GetFiles(Finder FileFinder, string path)
        {
            FileFinder.lst_files.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(path);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.*"); //Getting Text files

            foreach (FileInfo file in Files)
            {

                //Create the complete path
                string CompletePath = path + "/" + file.Name;

                var lastModified = File.GetLastWriteTime(CompletePath);
                string user = File.GetAccessControl(CompletePath).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
                ListViewItem lvi = new ListViewItem();

                //Add the classes to read
                Class.ReadWord readWord = new Class.ReadWord();
                Class.SortAuthor sortAuthor = new Class.SortAuthor();
                Class.SortDate sortDate = new Class.SortDate();
                Class.SortFilename sortFilename = new Class.SortFilename();                

                //Variables used for compare how many sorts are used with how many sorts corresponds with the items found
                int NbSortsUsed = 0; //Variable to count the number of sorts
                int NbSortsRight = 0; //Variable to count the number of items who correspond to the sort

                //Sort by author
                if (FileFinder.txt_author.Text != "") //If the sort isn't empty, increment NbSortsUsed
                {
                    bool IsAuthor = sortAuthor.SortAuthorName(this, FileFinder, CompletePath); //Select the method to check the author
                    NbSortsUsed++;
                    if (IsAuthor) //If the sort corresponds, increment NbSortsRight
                    {
                        NbSortsRight++;
                    }
                }

                //Sort by date of last modification
                if (FileFinder.txt_date.Text != "")
                {
                    bool DateCorresponds = sortDate.SortDateModification(this, FileFinder, CompletePath); //Select the method to check the date
                    NbSortsUsed++;
                    if (DateCorresponds)
                    {
                        NbSortsRight++;
                    }
                }

                //Sort by file name
                if (FileFinder.txt_file.Text != "")
                {
                    bool FilenameCorresponds = sortFilename.SortFilenameString(this, FileFinder, CompletePath); //Select the method to check the file name
                    NbSortsUsed++;
                    if (FilenameCorresponds)
                    {
                        NbSortsRight++;
                    }
                }

                //Compares if the numbers of sorts and the nombers of items who corresponds with the sort are similar
                if (NbSortsUsed == NbSortsRight)
                {
                    //Sort by content if corresponds on other criterias. The code is here to prevent of spending time on opening and closing useless files
                    /*if (FileFinder.txt_keyWord.Text != "")
                    {*/
                        //Select the method to read the file
                        /*bool ReadMethodWord = file.Name.ToLower().Contains(".doc"); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive

                        if (ReadMethodWord)
                        {

                        }
                    }*/

                    FileFinder.lst_files.Items.Add(lvi);

                    lvi.Text = file.Name;
                    lvi.SubItems.Add(file.Length.ToString() + " octets");
                    lvi.SubItems.Add(user.ToString());
                    lvi.SubItems.Add(lastModified.ToString());
                }

            }
        }
    }
}