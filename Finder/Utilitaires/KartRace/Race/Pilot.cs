using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race
{
    /// <summary>
    /// Cette classe rassemble les informations relatives au pilote
    /// </summary>
    class Pilot
    {
        /// <summary>
        /// Numéro de license FIAA
        /// </summary>
        public int _license;

        /// <summary>
        /// Nom et prénom du pilote
        /// </summary>
        public String _name;

        /// <summary>
        /// Disponibilité du pilote
        /// </summary>
        public bool _active;

        /// <summary>
        /// Constructeur complet
        /// </summary>
        /// <param name="License">Le numéro de license</param>
        /// <param name="Name">Nom du pilote</param>
        /// <param name="Active">Pilote disponible Oui/Non</param>
        public Pilot(int License, String Name, bool Active)
        {
            _license = License;
            _name = Name;
            _active = Active; // no disponible
        }

        /// <summary>
        /// Permet de savoir si le pilote est disponible
        /// </summary>
        /// <returns>true si prêt à partir</returns>
        public bool isActive()
        {
            return _active;
        }

    }
}
