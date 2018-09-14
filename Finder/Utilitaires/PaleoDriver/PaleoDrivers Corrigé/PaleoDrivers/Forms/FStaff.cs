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
        private List<Driver> _Staff;
        private Random aleaDriver = new Random();
        private const int NbFields = 5;
        private const string FName = "Staff.txt";

        public FStaff()
        {
            InitializeComponent();
            _Staff = new List<Driver>();
            int nbLignes = 0;
            int numPermis = 0;
            string errorMsg = "";
            if (!File.Exists(FName)) 
                errorMsg += (Environment.NewLine+string.Format("Fichier introuvable ({0})", FName));
            else
            {
                StreamReader driver = new StreamReader(FName); // Ouverture du fichier, qui est dans le même dossier que l'exécutable
                driver.ReadLine(); // skip header line
                nbLignes++;
                while (!driver.EndOfStream)
                {
                    nbLignes++;
                    string line = driver.ReadLine(); // Lecture d'une ligne complète
                    string[] vals = line.Split(','); // Découpage de la ligne en plusieurs string autour de la virgule
                    if (vals.Length > NbFields) 
                        errorMsg += (Environment.NewLine+string.Format("Trop de champs dans la ligne {0}", nbLignes));
                    else
                        if (vals.Length < NbFields) 
                            errorMsg += (Environment.NewLine+string.Format("Trop peu de champs dans la ligne {0}", nbLignes));
                        else
                            if (line.Length < 20)
                                errorMsg += (Environment.NewLine + string.Format("Ligne trop courte ({0})", line));
                            else
                            {
                                for (int i = 0; i < vals.Length; i++) vals[i] = vals[i].Trim(); // Remove all blanks
                                string nom = vals[0];
                                string prenom = vals[1];
                                string adresse = vals[2];
                                if (!int.TryParse(vals[3], out numPermis))
                                    errorMsg += (Environment.NewLine + string.Format("Numéro de permis invalide ({0})", vals[3]));
                                else
                                    if (numPermis < 1000)
                                        errorMsg += (Environment.NewLine + string.Format("Numéro de permis invalide ({0})", numPermis));
                                    else
                                    {
                                        bool pret = (vals[4].Trim() == "1");
                                        _Staff.Add(new Driver(prenom, nom, adresse, numPermis, pret)); // Ajouter le vehicule à la liste 
                                    }
                            }
                }
            }
            // Check if there was any error
            if (errorMsg != "")
            {
                MessageBox.Show(string.Format("Problème de fichier staff ({0}): {1}", FName, errorMsg));
                _Staff.Clear();
            }
        }

        public Driver getRandomDriver()
        {
            int NbDriver = _Staff.Count;
            int choixDriver = aleaDriver.Next(NbDriver);
            return _Staff.ElementAt(choixDriver);
        }

        private void ShowDriver()
        {
            foreach (Driver d in _Staff)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                DataGridViewTextBoxCell dgvct;
                DataGridViewCheckBoxCell dgvcc;

                dgvct = new DataGridViewTextBoxCell();
                dgvct.Value = d._fname;
                dgvr.Cells.Add(dgvct);
                dgvct = new DataGridViewTextBoxCell();
                dgvct.Value = d._lname;
                dgvr.Cells.Add(dgvct);
                dgvct = new DataGridViewTextBoxCell();
                dgvct.Value = d._address;
                dgvr.Cells.Add(dgvct);
                dgvct = new DataGridViewTextBoxCell();
                dgvct.Value = d._license.ToString();
                dgvr.Cells.Add(dgvct);
                dgvcc = new DataGridViewCheckBoxCell();
                dgvcc.Value = d._ready;
                dgvr.Cells.Add(dgvcc);

                dgvDriver.Rows.Add(dgvr);
            }
        }

        private void FStaff_Load(object sender, EventArgs e)
        {
            ShowDriver();
        }

        /// <summary>
        /// Allows to know if the staff has been loaded properly or not
        /// </summary>
        /// <returns></returns>
        public bool isOK()
        {
            return (_Staff.Count > 0);
        }

    }
}
