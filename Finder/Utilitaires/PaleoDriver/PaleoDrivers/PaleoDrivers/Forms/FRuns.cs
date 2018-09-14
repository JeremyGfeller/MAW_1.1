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

namespace PaleoDrivers
{
    public partial class FRuns : Form
    {
        public List<Run> _run;
        private FFleet _fleet; // Le formulaire fleet qui contient les véhicules
        private FStaff _staff;
        Random generator = new Random();

        public FRuns()
        {
            InitializeComponent();
            LoadRuns();
        }

        private void LoadRuns()
        {
            string[] KnownPlaces = { "Prod","Grande scène","Arches","Dôme","Club Tent","Détour","Honda","Cornavin","Cointrin","Mandarin Oriental","Chavannes","Divonne","Georges V", "Continental", "Mövenpick" };
            string[] Artists = { "Black Eyed Peas", "David Bowie", "Imagine Dragons", "Pink", "Katie Perry", "Sting", "Mylène Farmer", "Calogero", "Bruce Springsteen", "Synapson", "Damian Marley", "Placebo", "Muse", "Coldplay", "Radiohead", "Björk" };

            _run = new List<Run>();
            for (int run=0; run < 15; run++)
            {
                int nbv = 1; // By default: only one vehicle
                if (generator.Next(8) <2) // Multi vehicle run
                    nbv = generator.Next(2,5);
                List<DrivenVehicle> logi = new List<DrivenVehicle>();
                for (int dv = 0; dv < nbv; dv++)
                    logi.Add(new DrivenVehicle(FMenu._Fleet.getRandomVehicle(), FMenu._Staff.getRandomDriver()));

                int nbstops = 2; // By default: two-stops path
                if (generator.Next(8) <2) // Multi stops run
                    nbstops = generator.Next(3,6);
                List<string> path = new List<string>();
                for (int stop = 0; stop < nbstops; stop++)
                    path.Add(KnownPlaces[generator.Next(KnownPlaces.Length)]);

                _run.Add(new Run(logi,DateTime.Now,path,Artists[generator.Next(Artists.Length)],generator.Next(1,9),""));
            }
        }

      
        private void ShowRun()
        {
            foreach (Run v in _run)
            {
                DataGridViewRow dgvr = new DataGridViewRow();
                DataGridViewTextBoxCell dgvct;
                DataGridViewCheckBoxCell dgvcc;

                dgvct = new DataGridViewTextBoxCell();
                dgvct.Value = v.getDriverVehicles();
                dgvr.Cells.Add(dgvct);

                dgvct = new DataGridViewTextBoxCell();
                dgvct.Value = v._datehour;
                dgvr.Cells.Add(dgvct);

                dgvct = new DataGridViewTextBoxCell();
                dgvct.Value = v.getParcours();
                dgvr.Cells.Add(dgvct);

                dgvct = new DataGridViewTextBoxCell();
                dgvct.Value = v._artist;
                dgvr.Cells.Add(dgvct);

                dgvct = new DataGridViewTextBoxCell();
                dgvct.Value = v._passengers;
                dgvr.Cells.Add(dgvct);

                dgvct = new DataGridViewTextBoxCell();
                dgvct.Value = v._info;
                dgvr.Cells.Add(dgvct);

                dgvRun.Rows.Add(dgvr);
            }
        }

        private void FRuns_Load(object sender, EventArgs e)
        {
            ShowRun();

            // Code en commentaire permet d'afficher en messagebox chaque fonction pour les testés
            /*DrivenVehicle drivervehicle1 = new DrivenVehicle(FMenu._Fleet.getRandomVehicle(), FMenu._Staff.getRandomDriver());
            MessageBox.Show("Vehicule et conducteur aléatoire : " + drivervehicle1.getDriverVehicle());

            Run r1 = _run.ElementAt(0);
            MessageBox.Show("Le parcours du premier run : " + r1.getParcours());

            Run DV1 = _run.ElementAt(0);
            MessageBox.Show("Drivers vehicles : " + DV1.getDriverVehicles());*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FMenu._Fleet.Close();
        }

        private void FRuns_FormClosed(object sender, FormClosedEventArgs e)
        {
            FMenu._Runs = null;
        }
    }
}
