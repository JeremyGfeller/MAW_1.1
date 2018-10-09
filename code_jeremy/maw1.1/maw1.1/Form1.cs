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
                
            if (fbd.ShowDialog() == DialogResult.OK)
                txtPath.Text = fbd.SelectedPath;

            /*using (FolderBrowserDialog fbd = new FolderBrowserDialog())
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

                    // A VOIR !!
                    // https://www.youtube.com/watch?v=aonRoEokQeY
                }
            }*/
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();

            toolTip1.ShowAlways = true;
            if (txtPath.Text != "" && Directory.Exists(txtPath.Text))
                LoadDirectory(txtPath.Text);
            else
                MessageBox.Show("Select Directory!!");
        }

        public void LoadDirectory(string Dir)
        {

            DirectoryInfo di = new DirectoryInfo(Dir);
            TreeNode tds = treeView1.Nodes.Add(di.Name);
            tds.Tag = di.FullName;
            tds.StateImageIndex = 0;
            LoadFiles(Dir, tds);
            LoadSubDirectories(Dir, tds);
        }

        private void LoadFiles(string dir, TreeNode td)
        {
            string[] Files = Directory.GetFiles(dir, "*.*");

            // Loop through them to see files  
            foreach (string file in Files)
            {
                string author = System.IO.File.GetAccessControl(file).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString(); //System.Security.Principal.NTAccount
                string SortedText = txtSort.Text;
                FileInfo fi = new FileInfo(file);
                /*
                TreeNode tds = td.Nodes.Add(fi.Name);
                tds.Tag = fi.FullName;
                tds.StateImageIndex = 1;
                tds.Text = fi.Name + author;
                */

                if (SortedText != "")
                {
                    if(author == SortedText)
                    {
                        TreeNode tds = td.Nodes.Add(fi.Name);
                        tds.Tag = fi.FullName;
                        tds.StateImageIndex = 1;
                        tds.Text = fi.Name + author + SortedText + "Correspond";
                    }
                    else
                    {
                        TreeNode tds = td.Nodes.Add(fi.Name);
                        tds.Tag = fi.FullName;
                        tds.StateImageIndex = 1;
                        tds.Text = fi.Name + author + SortedText + "Correspond pas";
                    }
                }
                else
                {
                    TreeNode tds = td.Nodes.Add(fi.Name);
                    tds.Tag = fi.FullName;
                    tds.StateImageIndex = 1;
                    tds.Text = fi.Name + author;
                }
            }
        }

        private void LoadSubDirectories(string dir, TreeNode td)
        {
            // Get all subdirectories  
            string[] subdirectoryEntries = Directory.GetDirectories(dir);
            // Loop through them to see if they have any other subdirectories  
            foreach (string subdirectory in subdirectoryEntries)
            {
                DirectoryInfo di = new DirectoryInfo(subdirectory);
                TreeNode tds = td.Nodes.Add(di.Name);
                tds.StateImageIndex = 0;
                tds.Tag = di.FullName;
                LoadFiles(subdirectory, tds);
                LoadSubDirectories(subdirectory, tds);
            }
        }

        private void treeView1_MouseMove(object sender, MouseEventArgs e)
        {
            // Get the node at the current mouse pointer location.  
            TreeNode theNode = this.treeView1.GetNodeAt(e.X, e.Y);

            // Set a ToolTip only if the mouse pointer is actually paused on a node.  
            if (theNode != null && theNode.Tag != null)
            {
                // Change the ToolTip only if the pointer moved to a new node.  
                if (theNode.Tag.ToString() != this.toolTip1.GetToolTip(this.treeView1))
                    this.toolTip1.SetToolTip(this.treeView1, theNode.Tag.ToString());

            }
            else     // Pointer is not over a node so clear the ToolTip.  
            {
                this.toolTip1.SetToolTip(this.treeView1, "");
            }
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {

        }
    }
}