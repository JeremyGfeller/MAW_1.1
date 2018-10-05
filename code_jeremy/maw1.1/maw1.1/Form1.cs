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
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {                
            if (fbd.ShowDialog() == DialogResult.OK)
                txtPath.Text = fbd.SelectedPath;
            
            // A VOIR !!
            // https://www.youtube.com/watch?v=aonRoEokQeY
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            webBrowser.Url = new Uri(fbd.SelectedPath);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            webBrowser.GoBack();
        }

        private void btnGoForward_Click(object sender, EventArgs e)
        {
            webBrowser.GoForward();
        }
    }
}