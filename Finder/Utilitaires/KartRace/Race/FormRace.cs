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

namespace Race
{
    public partial class FormRace : Form
    {
        private List<Kart> Karts;
        private List<Pilot> Pilots;

        public FormRace()
        {
            InitializeComponent();
        }

        private void FormRace_Load(object sender, EventArgs e)
        {
            using (StreamReader fkarts = new StreamReader("karts.txt")) // Ouverture du fichier, qui est dans le même dossier que l'exécutable
            {
                Karts = new List<Kart>(); // Instancier la liste de karts (vide)
                fkarts.ReadLine(); // sauter la première ligne qui contient les en-têtes de colonne
                while (!fkarts.EndOfStream)
                {
                    string line = fkarts.ReadLine(); // Lecture d'une ligne complète
                    string[] vals = line.Split(','); // Découpage de la ligne en plusieurs string autour de la virgule
                    int number = int.Parse(vals[0]);
                    int power = int.Parse(vals[1]);
                    int km = int.Parse(vals[2]);
                    bool ready = (vals[3] == "1");
                    Karts.Add(new Kart(number, km, power, ready)); // Ajouter le nouveau kart à la liste
                }
            }

            using (StreamReader fpilots = new StreamReader("pilots.txt")) // Ouverture du fichier, qui est dans le même dossier que l'exécutable
            {
                Pilots = new List<Pilot>(); // Instancier la liste de karts (vide)
                fpilots.ReadLine(); // sauter la première ligne qui contient les en-têtes de colonne
                while (!fpilots.EndOfStream)
                {
                    string line = fpilots.ReadLine(); // Lecture d'une ligne complète
                    string[] vals = line.Split(','); // Découpage de la ligne en plusieurs string autour de la virgule
                    int license = int.Parse(vals[0]);
                    string name = (vals[1]);
                    bool active = (vals[2] == "1");
                    Pilots.Add(new Pilot(license, name, active)); // Ajouter le nouveau pilote à la liste
                }
            }

            ShowKartsAvailable();

            int nbKartsOk = 0; // Nombre de karts en état de rouler
            foreach (Kart k in Karts) // Evaluer le parc des karts
            {
                if (k.isReady())
                {
                    nbKartsOk++;
                }
            }
            MessageBox.Show(string.Format("{0} karts lus du fichier, {1} sont en état", Karts.Count, nbKartsOk));
        }

        private void AddToList(string Racer)
        {
            lstRace.Items.Add(Racer);
        }

        private void ShowKartsAvailable()
        {
            int nbRepl = 0;
            foreach (Kart k in Karts)
                if (k.isFree() && k.isReady()) nbRepl++;
            lblKartsLeft.Text = "Il y a " + nbRepl.ToString() + " Karts disponibles";
        }


        private void cmdNewRace_Click(object sender, EventArgs e)
        {
            foreach (Pilot p in Pilots)
            {
                if (p.isActive())
                {
                    foreach (Kart k in Karts)
                    {
                        if (k.isFree() && k.isReady())
                        {
                            k.setPilot(p);
                            AddToList(string.Format("{0} au volant du kart {1}", p._name, k._number));
                            break;
                        }
                    }
                }
            }
            ShowKartsAvailable();
        }
    }
}
