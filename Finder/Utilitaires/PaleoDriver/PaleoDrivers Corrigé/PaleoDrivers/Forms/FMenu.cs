using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaleoDrivers
{
    public partial class FMenu : Form
    {
        public static FFleet _Fleet = null;
        public static FRuns _Runs = null;
        public static FSchedule _Schedule = null;
        public static FStaff _Staff = null;
        public static FStats _Stats = null;

        public FMenu()
        {
            InitializeComponent();
            _Fleet = new FFleet();
            _Staff = new FStaff();
            if (!_Fleet.isOK() || !_Staff.isOK())
            {
                MessageBox.Show("Données incomplètes: l'application ne peut pas démarrer!");
                Environment.Exit(0);
                return;
            }
            _Schedule = new FSchedule();
            _Stats = new FStats();
            _Runs = new FRuns();
        }

        private void cmdFleet_Click(object sender, EventArgs e)
        {
            _Fleet.Visible = !_Fleet.Visible;
        }

        private void cmdStaff_Click(object sender, EventArgs e)
        {
            _Staff.Visible = !_Staff.Visible;
        }

        private void cmdRuns_Click(object sender, EventArgs e)
        {
            _Runs.Visible = !_Runs.Visible;
        }

        private void cmdStats_Click(object sender, EventArgs e)
        {
            _Stats.Visible = !_Stats.Visible;
        }

        private void cmdSchedule_Click(object sender, EventArgs e)
        {
            _Schedule.Visible = !_Schedule.Visible;
        }
    }
}
