using System;
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
using iTextSharp.text.pdf.parser;

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
            treeView1.Nodes.Clear();

            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
                
            if (fbd.ShowDialog() == DialogResult.OK)
                txtPath.Text = fbd.SelectedPath;
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
                FileInfo fi = new FileInfo(file); //Used to get informations about the files

                //Author
                string author = System.IO.File.GetAccessControl(file).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString(); //Return the author of the file
                string SortedText = txtSort.Text; //Store the value of the textbox in SortedText
                bool SortedResult = author.ToLower().Contains(SortedText.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
                
                //Date
                DateTime GetDateCreation = File.GetCreationTime(file); //Return the date of creation of the file
                string DateCreationInString = GetDateCreation.ToString(); //Store the date in a string
                string DateCreation = DateTime.Parse(DateCreationInString).ToString("dd.MM.yyyy"); //Change the format of the date
                string SortedText2 = txtSort2.Text; //Store the value of the textbox in SortedText2
                bool SortedResultDate = DateCreation.Contains(SortedText2); //Return 1 if the string countains the sort typed by the user.

                //File name
                string FileName = System.IO.Path.GetFileName(file); //Return the name + extension of the file
                string SortedText3 = txtSort3.Text; //Store the value of the textbox in SortedText3
                bool SortedResultName = FileName.ToLower().Contains(SortedText3.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive


                //Chose read method
                bool ReadMethodWord = FileName.ToLower().Contains(".doc"); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
                bool ReadMethodExcel = FileName.ToLower().Contains(".xls"); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
                bool ReadMethodPowerPoint = FileName.ToLower().Contains(".ppt"); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
                bool ReadMethodPdf = FileName.ToLower().Contains(".pdf"); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive

                //Content of file
                string SortedText4 = txtSort4.Text; //Store the value of the textbox in SortedText4
                
                //Variables used for compare how many sorts are used with how many sorts corresponds with the items found
                int NbSortsUsed = 0; //Variable to count the number of sorts
                int NbSortsRight = 0; //Variable to count the number of items who correspond to the sort
              
                //Sort by author
                if (SortedText != "") //If the sort isn't empty, increment NbSortsUsed
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

                //Sort by content
                if (SortedText4 != "")
                {
                    NbSortsUsed++;
                    bool SortedContent = false; //Create the bool variable before the if to prevent of errors and shows if content were corresponding 

                    if (ReadMethodWord)
                    {
                        Microsoft.Office.Interop.Word.Application Word = new Microsoft.Office.Interop.Word.Application(); //Initialise the application
                        object miss = System.Reflection.Missing.Value; //Ref for open word doc
                        object path = file; //Stock the path of the file
                        object readOnly = true; //Put the file in read only
                        Microsoft.Office.Interop.Word.Document docs = Word.Documents.Open(ref path, ref miss, ref readOnly, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss, ref miss); //Open application with all parameters
                        string WordText = ""; //Variable to store the text in the document
                        for (int i = 0; i < docs.Paragraphs.Count; i++) //Store the text of each paragraph
                        {
                            WordText += " \r\n " + docs.Paragraphs[i + 1].Range.Text.ToString();
                        }
                        docs.Close(); //Close document
                        SortedContent = WordText.ToLower().Contains(SortedText4.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
                    }
                    else if (ReadMethodExcel)
                    {

                        Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application(); //Initialise the application
                        Microsoft.Office.Interop.Excel.Workbook xlWorkbook = Excel.Workbooks.Open(file);
                        Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
                        Microsoft.Office.Interop.Excel.Range xlRange = xlWorksheet.UsedRange;

                        string ExcelTempText = "";
                        string ExcelText = "";
                        int rCnt;
                        int cCnt;
                        int rw = 0;
                        int cl = 0;

                        rw = xlRange.Rows.Count;
                        cl = xlRange.Columns.Count;

                        for (rCnt = 1; rCnt <= rw; rCnt++)
                        {
                            for (cCnt = 1; cCnt <= cl; cCnt++)
                            {
                                ExcelTempText = (string)(xlRange.Cells[rCnt, cCnt] as Microsoft.Office.Interop.Excel.Range).Value2;
                                ExcelText += " \r\n " + ExcelTempText;
                            }
                        }

                        xlWorkbook.Close(true, null, null);
                        Excel.Quit();
                        SortedContent = ExcelText.ToLower().Contains(SortedText4.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
                    }
                    else if (ReadMethodPdf)
                    {
                        iTextSharp.text.pdf.PdfReader reader = new iTextSharp.text.pdf.PdfReader(file);
                        StringBuilder sb = new StringBuilder();
                        for(int i=1;i<=reader.NumberOfPages; i++)
                        {
                            sb.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                        }
                        reader.Close();
                        SortedContent = sb.ToString().ToLower().Contains(SortedText4.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
                    }
                    else
                    {
                        //Content
                        string ReadText = System.IO.File.ReadAllText(file); //Return the text as one string
                        SortedContent = ReadText.ToLower().Contains(SortedText4.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
                    }
                /*else if (ReadMethodPowerPoint)
                {
                    Microsoft.Office.Interop.PowerPoint.Application PowerPoint_App = new Microsoft.Office.Interop.PowerPoint.Application();
                    Microsoft.Office.Interop.PowerPoint.Presentations multi_presentations = PowerPoint_App.Presentations;
                    Microsoft.Office.Interop.PowerPoint.Presentation presentation = multi_presentations.Open(file);

                    string PowerPointText = "";
                    for (int i = 0; i < presentation.Slides.Count; i++)
                    {
                        foreach (var item in presentation.Slides[i + 1].Shapes)
                        {
                            var shape = (Microsoft.Office.Interop.PowerPoint.Shape)item;
                            if (shape.HasTextFrame == Microsoft.Office.Core.MsoTriState.msoTrue)
                            {
                                if (shape.TextFrame.HasText == Microsoft.Office.Core.MsoTriState.msoTrue)
                                {
                                    var textRange = shape.TextFrame.TextRange;
                                    var text = textRange.Text;
                                    PowerPointText += text + " ";

                                }
                            }
                        }
                    }
                    PowerPoint_App.Quit();
                    SortedContent = PowerPointText.ToLower().Contains(SortedText4.ToLower()); //Return 1 if the string countains the sort typed by the user. ToLower() to make the sort case insensitive
                */

                    if (SortedContent)
                    {
                        NbSortsRight++;
                    }
                }

                //Compares if the numbers of sorts and the nombers of items who corresponds with the sort are similar
                if (NbSortsUsed == NbSortsRight)
                {
                    TreeNode tds = td.Nodes.Add(fi.Name);
                    tds.Tag = fi.FullName;
                    tds.StateImageIndex = 1;
                    tds.Text = fi.Name + " - " + author + " - " + DateCreation;
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSort.Clear();
            txtSort2.Clear();
            txtSort3.Clear();
            txtSort4.Clear();
        }
    }
}