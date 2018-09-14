using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PaleoDrivers.Model;

namespace PaleoDrivers
{
    /// <summary>
    /// Fleet form: allow to manage the fleet data
    /// \author X. Carrel
    /// \version 1.0
    /// </summary>
    public partial class FFleet : Form
    {
        public List<Vehicle> _fleet;
        private Random alea = new Random();
        private const int NbFields = 9;
        private const string FName = "fleet.txt";
        public string errorMsg = ""; // message describing the error(s) that occurred during the load. Made public for automatic test
        private string[] errorMessages = { "Fichier introuvable", 
                                           "Trop de champs dans la ligne", 
                                           "Trop peu de champs dans la ligne",
                                           "Ligne trop courte",
                                           "Nombre de sièges invalide",
                                           "Nombre de sièges incorrect",
                                           "Valeur incorrecte pour KM"
                                         };

        public bool LoadFile(string fn)
        {
            _fleet = new List<Vehicle>();
            int nbLignes = 0;
            int nbSeats = 0;
            // Read fleet from text file
            if (!File.Exists(fn))
                errorMsg = string.Format("Erreur {0}: {1} ({2})",0,errorMessages[0], fn);
            else
            {
                StreamReader fleetfile = new StreamReader(fn);
                fleetfile.ReadLine(); // skip first line (headers)
                nbLignes++;
                while (!fleetfile.EndOfStream)
                {
                    nbLignes++;
                    string line = fleetfile.ReadLine();
                    string[] vals = line.Split(','); // File is CSV
                    if (vals.Length > NbFields)
                        errorMsg += (Environment.NewLine + string.Format("Erreur {0}: {1} à la ligne {2}", 1, errorMessages[1], nbLignes));
                    else
                        if (vals.Length < NbFields)
                            errorMsg += (Environment.NewLine + string.Format("Erreur {0}: {1} à la ligne {2}", 2, errorMessages[2], nbLignes));
                        else
                            if (line.Length < 20) // too short for a valid line
                                errorMsg += (Environment.NewLine + string.Format("Erreur {0}: {1} à la ligne {2}", 3, errorMessages[3], nbLignes));
                            else
                            {
                                for (int i = 0; i < vals.Length; i++) vals[i] = vals[i].Trim(); // Remove all blanks
                                // Analyse values
                                if (!int.TryParse(vals[3], out nbSeats))
                                    errorMsg += (Environment.NewLine + string.Format("Erreur {0}: {1} à la ligne {2}", 4, errorMessages[4], nbLignes));
                                else
                                    if (nbSeats < 2 || nbSeats > 9)
                                        errorMsg += (Environment.NewLine + string.Format("Erreur {0}: {1} à la ligne {2}", 5, errorMessages[5], nbLignes));
                                    else
                                    {
                                        bool ready = (vals[4].Trim() == "1");
                                        bool needGas = (vals[8].Trim() == "1");
                                        int km;
                                        if (!int.TryParse(vals[7], out km))
                                        {
                                            errorMsg += (Environment.NewLine + string.Format("Erreur {0}: {1} à la ligne {2}", 6, errorMessages[6], nbLignes));
                                        }
                                        else // Add vehicle to fleet
                                            _fleet.Add(new Vehicle(1, vals[0], vals[1], vals[2], nbSeats, ready, needGas, vals[5][0], vals[6], km));
                                    }
                            }
                }
                fleetfile.Close();
            }
            // Check if there was any error
            if (errorMsg != "")
            {
                _fleet.Clear(); // to prevent app from starting
                return false;
            }
            else
                return true;
        }

        public FFleet()
        {
            InitializeComponent();
            if (!LoadFile(FName))
                MessageBox.Show(string.Format("Problème de fichier fleet ({0}): {1}", FName, errorMsg));
        }

        /// <summary>
        /// Puts the content of the _fleet collection into the datagridview
        /// </summary>
        private void ShowFleet()
        {
            dgvFleet.Rows.Clear(); // remove all current rows

            DataGridViewRow tableRow;
            DataGridViewCell textCell;
            DataGridViewCheckBoxCell checkBoxCell;

            foreach (Vehicle v in _fleet)
            {
                // build row using vehicle's attributes
                tableRow = new DataGridViewRow();
                textCell = new DataGridViewTextBoxCell();
                textCell.Value = v._name;
                tableRow.Cells.Add(textCell);
                textCell = new DataGridViewTextBoxCell();
                textCell.Value = v._licensePlate;
                textCell.Style.WrapMode = DataGridViewTriState.True; // allow multi-line content
                tableRow.Cells.Add(textCell);
                textCell = new DataGridViewTextBoxCell();
                textCell.Value = v._model;
                tableRow.Cells.Add(textCell);
                textCell = new DataGridViewTextBoxCell();
                textCell.Value = v._nbSeats;
                tableRow.Cells.Add(textCell);
                checkBoxCell = new DataGridViewCheckBoxCell();
                checkBoxCell.Value = v._ready;
                tableRow.Cells.Add(checkBoxCell);
                textCell = new DataGridViewTextBoxCell();
                textCell.Value = v._type;
                tableRow.Cells.Add(textCell);
                textCell = new DataGridViewTextBoxCell();
                textCell.Value = v._renter;
                tableRow.Cells.Add(textCell);
                textCell = new DataGridViewTextBoxCell();
                textCell.Value = v._km;
                tableRow.Cells.Add(textCell);
                checkBoxCell = new DataGridViewCheckBoxCell();
                checkBoxCell.Value = v._needgas;
                tableRow.Cells.Add(checkBoxCell);

                // Add row to table
                dgvFleet.Rows.Add(tableRow);
            }
        }

        /// <summary>
        /// Load event handler.
        /// We read the fleet from a file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FFleet_Load(object sender, EventArgs e)
        {
            ShowFleet(); // Display fleet collection in the datagridview
        }

        /// <summary>
        /// Save the current fleet to a file.
        /// At this point, the data is read from the grid (not the _fleet collection)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdSave_Click(object sender, EventArgs e)
        {
            StreamWriter fleetfile = new StreamWriter("fleet.txt");
            fleetfile.WriteLine("Name, License, Model, NbSeats, Ready, NeedGas, Type, Renter, Km");
            string line;
            foreach (DataGridViewRow row in dgvFleet.Rows)
            {
                line = "";
                foreach (DataGridViewCell cell in row.Cells)
                    line += (cell.Value + ",");
                line = line.Substring(0, line.Length - 1);
                fleetfile.WriteLine(line);
            }
            fleetfile.Close();
        }

        /// <summary>
        /// Allows to know if the fleet has been loaded properly or not
        /// </summary>
        /// <returns></returns>
        public bool isOK()
        {
            return (_fleet.Count > 0);
        }

        /// <summary>
        /// Picks a vehicle at random within the fleet
        /// </summary>
        /// <returns>PaleoDrivers.Vehicle</returns>
        public Vehicle getRandomVehicle()
        {
            return _fleet.ElementAt(alea.Next(_fleet.Count));
        }
    }
}
