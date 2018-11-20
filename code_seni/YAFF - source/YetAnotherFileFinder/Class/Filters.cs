using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Linq;

/*
 * CHANGER
 * LES
 * TYPES VOIDS
 * MERCI
 */

namespace YetAnotherFileFinder.Class
{
    class Filters
    {
        string keyWord;
        string date;
        string author;

        //As the 3 fields can be filled, We need to put them in a string so we can use them later on.
        public void CheckFilter(YetAnotherFileFinder yaffFilter)
        {
            if (!string.IsNullOrEmpty(yaffFilter.txtKeyWord.Text))
            {
                keyWord = yaffFilter.txtKeyWord.Text;
            }
            if (!string.IsNullOrEmpty(yaffFilter.dtpDateModif.Text))
            {
                date = yaffFilter.dtpDateModif.Text;
            }
            if (!string.IsNullOrEmpty(yaffFilter.txtAuthor.Text))
            {
                author = yaffFilter.txtAuthor.Text;
            }
        }

        public void SearchWithFilter(YetAnotherFileFinder yaffFilter)
        {
            foreach(ListViewItem file in yaffFilter.lvwFiles.Items)
            {
                if (!file.Text.ToUpper().Contains(keyWord.ToUpper()))
                {
                    yaffFilter.lvwFiles.Items.Remove(file);
                }
                
            }
        } 
    }
}
