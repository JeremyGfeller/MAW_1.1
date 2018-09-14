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
        public List<Run> _runs;

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

            _runs = new List<Run>();
            for (int run=0; run < 15; run++)
            {
                int nbv = 1; // By default: only one vehicle
                if (generator.Next(8) <2) // Multi vehicle run
                    nbv = generator.Next(2,5);
                List<DrivenVehicle> logi = new List<DrivenVehicle>();
                for (int dv = 0; dv < nbv; dv++)
                    logi.Add(new DrivenVehicle(FMenu._Staff.getRandomDriver(),FMenu._Fleet.getRandomVehicle()));

                int nbstops = 2; // By default: two-stops path
                if (generator.Next(8) <2) // Multi stops run
                    nbstops = generator.Next(3,6);
                List<string> path = new List<string>();
                for (int stop = 0; stop < nbstops; stop++)
                    path.Add(KnownPlaces[generator.Next(KnownPlaces.Length)]);

                _runs.Add(new Run(logi,DateTime.Now,path,Artists[generator.Next(Artists.Length)],generator.Next(1,9),""));
            }
        }

        private void FRuns_Load(object sender, EventArgs e)
        {
            ShowRuns();
        }

        private void ShowRuns()
        {
            dgvRuns.Rows.Clear(); // remove all current rows
            dgvRuns.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;

            DataGridViewRow tableRow;
            DataGridViewCell textCell;
            DataGridViewCheckBoxCell checkBoxCell;

            foreach (Run r in _runs)
            {
                // build row using vehicle's attributes
                tableRow = new DataGridViewRow();
                textCell = new DataGridViewTextBoxCell();
                textCell.Value = r._idRun;
                tableRow.Cells.Add(textCell);
                textCell = new DataGridViewTextBoxCell();
                textCell.Value = r._artist;
                tableRow.Cells.Add(textCell);
                textCell = new DataGridViewTextBoxCell();
                textCell.Value = r._nbpax.ToString();
                tableRow.Cells.Add(textCell);
                textCell = new DataGridViewTextBoxCell();
                textCell.Value = r._moment.ToString("dd.MM HH:mm");
                tableRow.Cells.Add(textCell);
                textCell = new DataGridViewTextBoxCell();
                textCell.Style.WrapMode = DataGridViewTriState.True;
                textCell.Value = r.GetPath();
                tableRow.Cells.Add(textCell);
                textCell = new DataGridViewTextBoxCell();
                textCell.Style.WrapMode = DataGridViewTriState.True;
                textCell.Value = r.GetLogistics();
                tableRow.Cells.Add(textCell);
                textCell = new DataGridViewTextBoxCell();
                textCell.Value = r._infos;
                tableRow.Cells.Add(textCell);

                // Add row to table
                dgvRuns.Rows.Add(tableRow);
            }
        }

        private void dgvRuns_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rid = int.Parse(dgvRuns.Rows[e.RowIndex].Cells[0].Value.ToString());
            Run theRun = null;
            foreach (Run search in _runs)
                if (search._idRun == rid)
                {
                    theRun = search;
                    break;
                }
        }

    }
}
