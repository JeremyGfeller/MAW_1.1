using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finder
{
    public partial class Finder : Form
    {
        Class.Files files = new Class.Files();

        public string selectPath;
        public string selectFile;

        public Finder()
        {
            InitializeComponent();
        }

        public void btn_path_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                selectPath = fbd.SelectedPath;
                files.GetFiles(this, selectPath);
            }
        }
    }
}
