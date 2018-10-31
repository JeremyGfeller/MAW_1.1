﻿using System;
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
                string author = System.IO.File.GetAccessControl(file).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString(); //Return the author of the file
                string SortedText = txtSort.Text; 
                FileInfo fi = new FileInfo(file);

                DateTime GetDateCreation = File.GetCreationTime(file); //Return the date of creation of the file
                string DateCreationInString = GetDateCreation.ToString(); //Store the date in a string

                bool SortedResult = author.ToLower().Contains(SortedText.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
                
                string DateCreation = DateTime.Parse(DateCreationInString).ToString("dd.MM.yyyy");
                string SortedText2 = txtSort2.Text;
                bool SortedResultDate = DateCreation.Contains(SortedText2); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive

                string FileName = Path.GetFileName(file); //Return the name + extension of the file
                string SortedText3 = txtSort3.Text; //Store the value of the textbox in SortedText3
                bool SortedResultName = FileName.Contains(SortedText3); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
                
                int NbSortsUsed = 0; //Variable to count the number of sorts
                int NbSortsRight = 0; //Variable to count the number of items who correspond to the sort

                //Sort by author
                if(SortedText != "") //If the sort isn't empty, increment NbSortsUsed
                {
                    NbSortsUsed++;
                    if (SortedResult) //If the sort corresponds, increment NbSortsRight
                    {
                        NbSortsRight++;
                    }
                }
                
                //Sort by date of creation file
                if(SortedText2 != "")
                {
                    NbSortsUsed++;
                    if (SortedResultDate)
                    {
                        NbSortsRight++;
                    }
                }

                //Sort by file name
                if (SortedText3 != "")
                {
                    NbSortsUsed++;
                    if (SortedResultName)
                    {
                        NbSortsRight++;
                    }
                }

                //Compares if the numbers of sorts and the nombers of items who corresponds with the sort are similar
                if(NbSortsUsed == NbSortsRight)
                {
                    TreeNode tds = td.Nodes.Add(fi.Name);
                    tds.Tag = fi.FullName;
                    tds.StateImageIndex = 1;
                    tds.Text = fi.Name + " - " + DateCreation;
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
    }
}