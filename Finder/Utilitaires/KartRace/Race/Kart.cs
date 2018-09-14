using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    /// <summary>
    /// Cette classe rassemble les informations relatives à un Kart
    /// </summary>
    class Kart
    {
        /// <summary>
        /// Le numéro du kart (visible sur son carénage)
        /// </summary>
        public int _number;

        /// <summary>
        /// Puissance (en CV)
        /// </summary>
        public int _power;

        /// <summary>
        /// Nombre de kilomètres approximatifs parcourus par le kart
        /// </summary>
        public int _km;

        /// <summary>
        /// En état de rouler ou pas
        /// </summary>
        public bool _ready;

        /// <summary>
        /// Nom du pilote affecté au kart
        /// </summary>
        public String _pilot;

        /// <summary>
        /// Constructeur complet
        /// </summary>
        /// <param name="Number">Le numéro du kart (visible sur son carénage)</param>
        /// <param name="Km">Nombre de kilomètres approximatifs parcourus par le kart</param>
        /// <param name="Power">Puissance (en CV)</param>
        /// <param name="ok">En état de rouler ou pas</param>
        public Kart(int Number, int Km, int Power, bool ok)
        {
            _number = Number;
            _power = Power;
            _km = Km;
            _ready = ok;
            _pilot = null; // no pilot
        }

        /// <summary>
        /// Permet de savoir si le kart est en état de marche
        /// </summary>
        /// <returns>true si prêt à partir</returns>
        public bool isReady()
        {
            return _ready;
        }

        /// <summary>
        /// Permet de savoir si le kart a déjà un pilote assigné
        /// </summary>
        /// <returns>true si aucun pilote n'est assigné</returns>
        public bool isFree()
        {
            return (_pilot == null);
        }

        
        /// <summary>
        /// _Pilot possède un nom
        /// </summary>
        /// <param name="ThePilot">Selectionne un pilote</param>
        public void setPilot(Pilot ThePilot)
        {
            _pilot = ThePilot._name;
        }
    }
}
