using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace YetAnotherFileFinder
{
    public partial class frmFolder : Form
    {

        public string SelectedFolder { get; set; }

        public frmFolder()
        {
            InitializeComponent();
        }
        

        private void Folder_Load(object sender, EventArgs e)
        {
            
        }
        
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            SelectedFolder = tvFolder.SelectedNode.Text;
            this.Close();
        }

        public void LoadFolders(string selectedDrive)
        {
            ListDirectory(tvFolder, selectedDrive);
        }

        private void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        private static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));

            return directoryNode;
        }

    }
}
