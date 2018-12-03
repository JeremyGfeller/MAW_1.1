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
                Class.ReadPdf readPdf = new Class.ReadPdf();
                Class.ReadExcel readExcel = new Class.ReadExcel();
                Class.ReadWindowsCompatible readWindowsCompatible = new Class.ReadWindowsCompatible();
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
                    //Search word. The if is there to prevent of waste useless time in reading files who aren't in the others sorts
                    if (FileFinder.txt_keyWord.Text != "")
                    {
                        //Select the method to read the content of the file
                        /*bool WordMethod = file.Name.ToLower().Contains(".doc");
                        bool PdfMethod = file.Name.ToLower().Contains(".pdf");
                        bool ExcelMethod = file.Name.ToLower().Contains(".xls");
                        bool defaultMethod = file.Name.ToLower().Contains(".txt");*/

                        string Extension = file.Name.ToLower().Split('.').Last();
                        //MessageBox.Show(Extension);
                        switch (Extension)
                        {
                            case "doc":
                            case "docx":
                                bool wordCorresponds = readWord.ReadWordFile(this, FileFinder, CompletePath);
                                if (wordCorresponds)
                                {
                                    FileFinder.lst_files.Items.Add(lvi);
                                    lvi.Text = file.Name;
                                    lvi.SubItems.Add(file.Length.ToString() + " octets");
                                    lvi.SubItems.Add(user.ToString());
                                    lvi.SubItems.Add(lastModified.ToString());
                                }
                                break;
                            case "xls":
                            case "xlsx":
                                bool excelCorresponds = readExcel.ReadExcelFile(this, FileFinder, CompletePath);
                                if (excelCorresponds)
                                {
                                    FileFinder.lst_files.Items.Add(lvi);
                                    lvi.Text = file.Name;
                                    lvi.SubItems.Add(file.Length.ToString() + " octets");
                                    lvi.SubItems.Add(user.ToString());
                                    lvi.SubItems.Add(lastModified.ToString());
                                }
                                break;
                            case "ppt":
                            case "pptx":
                                //MessageBox.Show("Power point");
                                break;
                            case "pdf":
                                bool pdfCorresponds = readPdf.ReadPdfFile(this, FileFinder, CompletePath);
                                if (pdfCorresponds)
                                {
                                    FileFinder.lst_files.Items.Add(lvi);
                                    lvi.Text = file.Name;
                                    lvi.SubItems.Add(file.Length.ToString() + " octets");
                                    lvi.SubItems.Add(user.ToString());
                                    lvi.SubItems.Add(lastModified.ToString());
                                }
                                break;
                            default:
                                bool windowsCompatibleCorresponds = readWindowsCompatible.ReadWindowsCompatibleFile(this, FileFinder, CompletePath);
                                if (windowsCompatibleCorresponds)
                                {
                                    FileFinder.lst_files.Items.Add(lvi);
                                    lvi.Text = file.Name;
                                    lvi.SubItems.Add(file.Length.ToString() + " octets");
                                    lvi.SubItems.Add(user.ToString());
                                    lvi.SubItems.Add(lastModified.ToString());
                                }
                                break;
                        }
                    }
                    else
                    {
                        FileFinder.lst_files.Items.Add(lvi);
                        lvi.Text = file.Name;
                        lvi.SubItems.Add(file.Length.ToString() + " octets");
                        lvi.SubItems.Add(user.ToString());
                        lvi.SubItems.Add(lastModified.ToString());
                    }
                }
            }
        }

        public void ReadFile(string selectPath, string selectFile)
        {
            Process.Start(Path.Combine(selectPath, selectFile));
        }
    }
}