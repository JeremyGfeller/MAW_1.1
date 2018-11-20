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
            string str = "";
            foreach (FileInfo file in Files)
            { 
                var lastModified = File.GetLastWriteTime(path + "/" + file.Name);
                string user = File.GetAccessControl(path + "/" + file.Name).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
                ListViewItem lvi = new ListViewItem();

                //Create the complete path
                string CompletePath = path + "/" + file.Name;

                //Add the classes to read
                Class.ReadWord readWord = new Class.ReadWord();
                Class.SortAuthor sortAuthor = new Class.SortAuthor();

                //Select the method to read the file
                bool ReadMethodWord = file.Name.ToLower().Contains(".doc"); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
                bool IsAuthor = sortAuthor.SortAuthorName(this, FileFinder, CompletePath);

               if(IsAuthor)
                {
                    FileFinder.lst_files.Items.Add(lvi);

                    lvi.Text = file.Name;
                    lvi.SubItems.Add(file.Length.ToString() + " octet ");
                    lvi.SubItems.Add(user.ToString());
                    lvi.SubItems.Add(lastModified.ToString());
                }

                //Call the classes to read
                if(ReadMethodWord)
                {
                    bool WordTextResult = readWord.ReadWordFile(this, FileFinder, CompletePath);

                    if(WordTextResult)
                    {
                        
                    }
                }
            }
        }
    }
}