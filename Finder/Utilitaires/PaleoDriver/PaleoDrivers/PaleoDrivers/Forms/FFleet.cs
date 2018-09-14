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
    public partial class FFleet : Form
    {
        public List<Vehicle> _fleet;
        private Random alea = new Random();
        
        private bool _firstline;
        int line;
        int i = 0;

        public FFleet()
        {
            InitializeComponent();
            _fleet = new List<Vehicle>();
            LoadFleet("Fleet.txt");
        }

        public Vehicle getRandomVehicle()
        {
            int NbVehicles = _fleet.Count;
            int choix = alea.Next(NbVehicles);
            return _fleet.ElementAt(choix);
        }

        public bool isOK()
        {
            return(_fleet.Count > 0);
        }
        /*
        private void AddVehicle(string vdesc)
        {
            if(_firstline)
            {
                txtFleet.Text = vdesc;
            }
            else
            {
                txtFleet.Text += (Environment.NewLine + vdesc);
                _firstline = false;
            }
        }

        private void AddVehicleFormated(string vdesc)
        {
            if (_firstline)
            {
                txtFleet2.Text = vdesc;
            }
            else
            {
                txtFleet2.Text += (Environment.NewLine + vdesc);
                _firstline = false;
            }            
        }
        */

        private void FFleet_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        /*
        private void AddToList(string v)
        {
            txtFleet.Text += (v + Environment.NewLine);
        }

        private void ListVehiclesToFill(object sender, EventArgs e)
        {
            List<Vehicle> vtf = _fleet.getlist();
            foreach (Vehicle v in vtf)
            {
                AddToList(v.description());
            }
        }
        */
        
        /// <summary>
        /// Permet de créer un data greedView et de l'afficher
        /// </summary>
        private void Showfleet()
        {
            foreach(Vehicle v in _fleet)
            {
                    //Remplir un DataGridView a l'aide d'une lecture d'un .txt
                    DataGridViewRow dgvr = new DataGridViewRow();
                    DataGridViewTextBoxCell dgvct;
                    DataGridViewCheckBoxCell dgvcc;

                    dgvct = new DataGridViewTextBoxCell();
                    dgvct.Value = v._name;
                    dgvr.Cells.Add(dgvct);

                    dgvct = new DataGridViewTextBoxCell();
                    dgvct.Value = v._license;
                    dgvr.Cells.Add(dgvct);

                    dgvct = new DataGridViewTextBoxCell();
                    dgvct.Value = v._model;
                    dgvr.Cells.Add(dgvct);

                    dgvct = new DataGridViewTextBoxCell();
                    dgvct.Value = v._nbseats;
                    dgvr.Cells.Add(dgvct);

                    dgvcc = new DataGridViewCheckBoxCell();
                    dgvcc.Value = v._ready;
                    dgvr.Cells.Add(dgvcc);

                    dgvcc = new DataGridViewCheckBoxCell();
                    dgvcc.Value = v._needgas;
                    dgvr.Cells.Add(dgvcc);

                    dgvct = new DataGridViewTextBoxCell();
                    dgvct.Value = v._type;
                    dgvr.Cells.Add(dgvct);

                    dgvct = new DataGridViewTextBoxCell();
                    dgvct.Value = v._renter;
                    dgvr.Cells.Add(dgvct);

                    dgvct = new DataGridViewTextBoxCell();
                    dgvct.Value = v._km;
                    dgvr.Cells.Add(dgvct);

                    dgvFleet.Rows.Add(dgvr);            // Ou afficher les diférents types de cellules créer au dessus
            }

        }
        
        private void FFleet_Load(object sender, EventArgs e)
        {
            
        }

        private void FFleet_FormClosed(object sender, FormClosedEventArgs e)
        {
            FMenu._Fleet = null;
        }

        public void LoadFleet(string FleetFileName)
        {
            if (!File.Exists(FleetFileName))
            {
                MessageBox.Show("Fichier absent");
                this.Close();
            }

            using (StreamReader fleetfile = new StreamReader(FleetFileName))      // Ouverture du fichier, qui est dans le même dossier que l'exécutable et création de "fleetfile"
            {
                fleetfile.ReadLine();
                while (!fleetfile.EndOfStream)
                {
                    string line = fleetfile.ReadLine();                         // Lis les lignes de "fleetfile" nommé au dessus
                    string[] values = line.Split(',');                          // Séparer des chaines de données grace aux ","
                    bool ready = (values[4].Trim() == "1");                     // Retirer tous les espaces et crée un booléen
                    bool needgas = (values[5].Trim() == "1");                   // Retirer tous les espaces et crée un booléen

                    _fleet.Add(new Vehicle(values[0].Trim(), values[1].Trim(), values[2].Trim(), int.Parse(values[3]), ready, needgas, values[6][1], values[7].Trim(), int.Parse(values[8]))); // Instancie le data greed view


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
                    else if (values[6] == "")
                    {
                        MessageBox.Show("Votre fichier est pourri");
                    }
                    else if (values[7] == "")
                    {
                        MessageBox.Show("Votre fichier est pourri");
                    }
                    else if (values[8] == "")
                    {
                        MessageBox.Show("Votre fichier est pourri");
                    }

                }
                Showfleet();
            }
        }
    }
}
