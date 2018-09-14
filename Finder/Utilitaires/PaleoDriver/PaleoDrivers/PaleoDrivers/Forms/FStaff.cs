using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PaleoDrivers.Model;
using System.IO;

namespace PaleoDrivers
{
    public partial class FStaff : Form
    {
        private List<Driver> _staff;
        private Random alea = new Random();

        public FStaff()
        {
            InitializeComponent();
            _staff = new List<Driver>();
            LoadStaff();
        }

        public Driver getRandomDriver()
        {
            int NbDrivers = _staff.Count;
            int choix = alea.Next(NbDrivers);
            return _staff.ElementAt(choix);
        }


        private void ShowStaff()
        {
            foreach (Driver v in _staff)
            {
                //Remplir un DataGridView a l'aide d'une lecture d'un .txt
                DataGridViewRow dgvr = new DataGridViewRow();
                DataGridViewTextBoxCell dgvct;
                DataGridViewCheckBoxCell dgvcc;

                dgvct = new DataGridViewTextBoxCell();
                dgvct.Value = v._nom;
                dgvr.Cells.Add(dgvct);

                dgvct = new DataGridViewTextBoxCell();
                dgvct.Value = v._prenom;
                dgvr.Cells.Add(dgvct);

                dgvct = new DataGridViewTextBoxCell();
                dgvct.Value = v._adresse;
                dgvr.Cells.Add(dgvct);

                dgvct = new DataGridViewTextBoxCell();
                dgvct.Value = v._permis;
                dgvr.Cells.Add(dgvct);

                dgvcc = new DataGridViewCheckBoxCell();
                dgvcc.Value = v._pret;
                dgvr.Cells.Add(dgvcc);

                dgvDriver.Rows.Add(dgvr);
            }
        }

        private void FStaff_Load(object sender, EventArgs e)
        {
            
        }

        private void FStaff_FormClosed(object sender, FormClosedEventArgs e)
        {
            FMenu._Staff = null;
        }

        private void LoadStaff()
        {
            if (!File.Exists("Staff.txt"))
            {
                MessageBox.Show("Fichier absent");
                this.Close();
            }

            using (StreamReader stafffile = new StreamReader("Staff.txt")) // Ouverture du fichier, qui est dans le même dossier que l'exécutable
            {
                stafffile.ReadLine();
                while (!stafffile.EndOfStream)
                {
                    string line = stafffile.ReadLine();
                    string[] values = line.Split(',');
                    bool pret = (values[4].Trim() == "1");

                    _staff.Add(new Driver(values[0].Trim(), values[1].Trim(), values[2].Trim(), int.Parse(values[3]), pret));

                    if (values[0] == "")
                    {
                        MessageBox.Show("Votre fichier est pourri");
                    }
                    else if (values[1] == "")
                    {
                        MessageBox.Show("Votre fichier est pourri");
                    }
                    else if (values[2] == "")
                    {
                        MessageBox.Show("Votre fichier est pourri");
                    }
                    else if (values[3] == "")
                    {
                        MessageBox.Show("Votre fichier est pourri");
                    }
                }
            }
            ShowStaff();
        }
    }
}
