using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace maw1._1
{
    public partial class Form1 : Form
    {
        List<string> listFiles = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            listFiles.Clear();
            listView.Items.Clear();
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    string[] files = Directory.GetFiles(fbd.SelectedPath);
                    string[] directorys = Directory.GetDirectories(fbd.SelectedPath);

                    foreach (string file in files)
                    {
                        imageList.Images.Add(System.Drawing.Icon.ExtractAssociatedIcon(file));
                        FileInfo fi = new FileInfo(file);
                        listFiles.Add(fi.FullName);
                        listView.Items.Add(fi.Name, imageList.Images.Count - 1);
                        //https://www.youtube.com/watch?v=EQa_3YiUicw
                    }

                    foreach (string directory in directorys)
                    {
                        FileInfo fi = new FileInfo(directory);
                        listFiles.Add(fi.FullName);
                        listView.Items.Add(fi.Name, Path.GetFileName(directory));
                    }

                    txtPath.Text = fbd.SelectedPath;

                    //https://www.c-sharpcorner.com/article/display-sub-directories-and-files-in-treeview/
                }
            }
        }
    }
}