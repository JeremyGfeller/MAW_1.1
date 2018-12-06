using System;
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
                if (lst_files.SelectedItems.Count != 0) //If a item is selected, focus item on the folder, else open folder without focus
                {
                    string selectPathAndFile = selectPath + "\\" + lst_files.SelectedItems[0].Text + "\\";
                    bool HasFile = true;
                    repository.openRep(selectPathAndFile, HasFile);
                }
                else
                {
                    bool HasFile = false;
                    repository.openRep(selectPath, HasFile);
                }
            }
        }

        // Fonction qui ouvre un fichier seléctionné
        private void btn_openFichier_Click(object sender, EventArgs e)
        {
            if (lst_files.SelectedItems.Count != 0)
            {
                selectFile = lst_files.SelectedItems[0].Text;
                files.ReadFile(selectPath, selectFile);
            }
            else
            {
                MessageBox.Show("Aucun fichier n'a été sélectionné.");
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(txt_path.TextLength > 1)
            {
                try
                {
                    selectPath = txt_path.Text;
                    files.GetFiles(this, selectPath);
                }
                catch
                {
                    MessageBox.Show("Le dossier sélectionné n'existe pas.");
                }
            }
            else
            {
                MessageBox.Show("Aucun dossier sélectionné.");
            }
        }
        
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_keyWord.Clear();
            txt_author.Clear();
            txt_date.Clear();
            txt_file.Clear();
        }
    }
}
