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
                lvi.Text = file.Name;
                lvi.SubItems.Add(file.Length.ToString() + " octet ");
                lvi.SubItems.Add(user.ToString());
                lvi.SubItems.Add(lastModified.ToString());

                //lvi.SubItems.Add(file.Name);
                FileFinder.lst_files.Items.Add(lvi);
            }
        }

        public void ReadFile(string selectPath, string selectFile)
        {
            Process.Start(Path.Combine(selectPath, selectFile));
        }
    }
}