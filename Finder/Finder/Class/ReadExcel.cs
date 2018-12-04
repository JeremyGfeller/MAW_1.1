using Spire.Xls;
using System;
using System.Text;

namespace Finder.Class
{
    class ReadExcel
    {
        public bool ReadExcelFile(Files files, Finder FileFinder, string CompletePath)
        {
            StringBuilder text = new StringBuilder();

            Workbook workbook = new Workbook();
            workbook.LoadFromFile(CompletePath);
            //Worksheet sheet = workbook.Worksheets[0];

            String txt_keyWord = FileFinder.txt_keyWord.Text; //Store the value given by the user

            foreach (Worksheet sheet in workbook.Worksheets) //Read all the page
            {
                foreach (CellRange range in sheet.FindAllString(txt_keyWord.ToLower(), true, true))
                {
                    return true; //If the text correspond, a booleon of type true is returned
                }
            }
            return false; //Else, a false is returned
        }
    }
}

