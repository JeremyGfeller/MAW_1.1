﻿using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Finder.Class
{
    class Files
    {
        public void GetFiles(Finder FileFinder, string path)
        {
            FileFinder.lst_files.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(path);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.*"); //Getting Text files

            int FoundFiles = 0; //Variable to calcule the number of files found
            int FoundWords = 0; //Variable to calcule the number of files found

            //Variables used for compare how many sorts are used with how many sorts corresponds with the items found
            int NbSortsUsed = 0; //Variable to count the number of sorts
            int NbSortsRight = 0; //Variable to count the number of items who correspond to the sort

            if (Files.Count() == 0)
            {
                MessageBox.Show("Il n'existe aucun fichier dans le dossier sélectionné.");
            }
            
            //Add the classes to read
            Class.ReadWord readWord = new Class.ReadWord();
            Class.ReadPdf readPdf = new Class.ReadPdf();
            Class.ReadExcel readExcel = new Class.ReadExcel();
            Class.ReadWindowsCompatible readWindowsCompatible = new Class.ReadWindowsCompatible();
            Class.SortAuthor sortAuthor = new Class.SortAuthor();
            Class.SortDate sortDate = new Class.SortDate();
            Class.SortFilename sortFilename = new Class.SortFilename();

            foreach (FileInfo file in Files)
            {
                //ListViewItem lvi = new ListViewItem();

                //Create the complete path
                string CompletePath = path + "/" + file.Name;

                var lastModified = File.GetLastWriteTime(CompletePath);
                string user = File.GetAccessControl(CompletePath).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();

                //Variables used for compare how many sorts are used with how many sorts corresponds with the items found
                NbSortsUsed = 0; //Variable to count the number of sorts
                NbSortsRight = 0; //Variable to count the number of items who correspond to the sort

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
                    //Count the number of files find
                    FoundFiles++;

                    //Search word. The if is there to prevent of waste useless time in reading files who aren't in the others sorts
                    if (FileFinder.txt_keyWord.Text != "")
                    {
                        string Extension = file.Name.ToLower().Split('.').Last();
                        switch (Extension)
                        {
                            case "doc":
                            case "docx":
                                try
                                {
                                    bool wordCorresponds = readWord.ReadWordFile(this, FileFinder, CompletePath);
                                    if (wordCorresponds)
                                    {
                                        ShowFiles(FileFinder, file, user, lastModified);
                                        FoundWords++;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Une erreur est survenue, un document word est peut-être ouvert.");
                                }
                                break;
                            case "xls":
                            case "xlsx":
                                try
                                {
                                    bool excelCorresponds = readExcel.ReadExcelFile(this, FileFinder, CompletePath);
                                    if (excelCorresponds)
                                    {
                                        ShowFiles(FileFinder, file, user, lastModified);
                                        FoundWords++;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Une erreur est survenue, un tableau excel est peut-être ouvert.");
                                }
                                break;
                            case "ppt":
                            case "pptx":
                                //MessageBox.Show("Power point");
                                break;
                            case "pdf":
                                try
                                {
                                    bool pdfCorresponds = readPdf.ReadPdfFile(this, FileFinder, CompletePath);
                                    if (pdfCorresponds)
                                    {
                                        ShowFiles(FileFinder, file, user, lastModified);
                                        FoundWords++;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Une erreur est survenue, un document pdf est peut-être ouvert.");
                                }
                                break;
                            //Image format
                            case "png":
                            case "jpg":
                            case "jpeg":
                            case "gif":
                            case "bmp":
                            // Video format
                            case "avi":
                            case "wmv":
                            case "mov":
                            case "mkv":
                            case "flv":
                            // Audio format
                            case "wav":
                            case "bwf":
                            case "raw":
                            case "flac":
                            case "mp3":
                            case "wma":
                            case "aac":
                            case "mp4":
                            case "mxp4":
                                break;
                            default:
                                try
                                {
                                    bool windowsCompatibleCorresponds = readWindowsCompatible.ReadWindowsCompatibleFile(this, FileFinder, CompletePath);
                                    if (windowsCompatibleCorresponds)
                                    {
                                        ShowFiles(FileFinder, file, user, lastModified);
                                        FoundWords++;
                                    }
                                }
                                catch
                                {
                                    MessageBox.Show("Une erreur est survenue, un document compatible a windows est peut-être ouvert.");
                                }
                                break;
                        }
                    }
                    else
                    {
                        ShowFiles(FileFinder, file, user, lastModified);
                        FoundWords++;
                    }
                }
            }

            if(FoundFiles == 0 && NbSortsUsed >= 1 || FoundWords == 0)
            {
                MessageBox.Show("Aucun fichier ne correspond aux critères de recherche.");
            }
        }

        public void ReadFile(string selectPath, string selectFile)
        {
            Process.Start(Path.Combine(selectPath, selectFile));
        }

        public void ShowFiles(Finder FileFinder, FileInfo file, string user, System.DateTime lastModified)
        {
            ListViewItem lvi = new ListViewItem();

            FileFinder.lst_files.Items.Add(lvi);
            lvi.Text = file.Name;
            lvi.SubItems.Add(file.Length.ToString() + " octets");
            lvi.SubItems.Add(user.ToString());
            lvi.SubItems.Add(lastModified.ToString());
        }
    }
}