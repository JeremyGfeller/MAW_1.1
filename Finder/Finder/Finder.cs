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
        // Instanciation des classes
        Class.Files files = new Class.Files();
        Class.OpenRep repository = new Class.OpenRep();

        // Le chemin amenant au dossier
        public string selectPath;

        // Le fichier seléctionné dans le dossier
        public string selectFile;

        public Finder()
        {
            InitializeComponent();
        }

        public void btn_path_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                selectPath = fbd.SelectedPath;
                files.GetFiles(this, selectPath);
                txt_path.Text = selectPath;
            }
        }

        // Fonction qui ouvre le répertoire dans lequel la recherche a été faite
        private void btn_openDirectory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectPath))
            {
                MessageBox.Show("Aucun répertoire n'a été sélectionné.");
            }
            else
            {
                repository.openRep(selectPath);
            }
        }

        // Fonction qui ouvre un fichier seléctionné
        private void btn_openFichier_Click(object sender, EventArgs e)
        {
            selectFile = lst_files.SelectedItems[0].Text;
            if (string.IsNullOrEmpty(selectPath))
            {
                MessageBox.Show("Aucun répertoire n'a été sélectionné.");
            }
            else if (string.IsNullOrEmpty(selectPath))
            {
                MessageBox.Show("Aucun fichier n'a été sélectionné.");
            }
            else
            {
                files.ReadFile(selectPath, selectFile);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            selectPath = txt_path.Text;
            files.GetFiles(this, selectPath);
        }
    }
}
