using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Krohonde
{
    public partial class Log : Form
    {
        public string filter = "";

        public Log()
        {
            InitializeComponent();
        }

        public void Logger(string s)
        {
            lstLog.Items.Insert(0, s);
        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            //hide()
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            filter = txtFilter.Text;
        }
    }
}
