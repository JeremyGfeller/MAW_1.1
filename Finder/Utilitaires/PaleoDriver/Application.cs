using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Menu : Form
    {
        Drivers _Drivers = null;
        Statistics _Statistics = null;
        Runs _Runs = null;
        Vehicles _Vehicles = null;

        public Menu()
        {
            InitializeComponent();
        }

        private void btnDrivers_Click(object sender, EventArgs e)
        {
            if (_Drivers == null)
            {
                // Ouverture formulaire Drivers
                _Drivers = new Drivers();           // Créer l'objet
                _Drivers.Show();                    // Montre le formulaire
            }
            else
            {
                _Drivers.Activate();
            }
        }

        private void btnStatistics_Click(object sender, EventArgs e)
        {
            if (_Statistics == null)
            {
                // Ouverture formulaire Statistics
                _Statistics = new Statistics();     // Créer l'objet
                _Statistics.Show();                 // Montre le formulaire
            }
            else
            {
                _Statistics.Activate();
            }
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            if(_Vehicles == null)
            {
                // Ouverture formulaire Vehicle
                _Vehicles = new Vehicles();         // Créer l'objet
                _Vehicles.Show();                   // Montre le formulaire
            }
            else
            {
                _Vehicles.Activate();
            }

        }

        private void btnRuns_Click(object sender, EventArgs e)
        {
            if (_Runs == null)
            {
                // Ouverture formulaire Runs  
                _Runs = new Runs();                // Créer l'objet
                _Runs.Show();                      // Montre le formulaire
            }
            else
            {
                _Runs.Activate();
            }
        }
    }
}
