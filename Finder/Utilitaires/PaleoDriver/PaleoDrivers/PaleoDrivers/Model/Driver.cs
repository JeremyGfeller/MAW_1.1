using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaleoDrivers.Model
{
    public class Driver
    {
        public string _nom;
        public string _prenom;
        public string _adresse;
        public int _permis;
        public bool _pret;
        public Driver (string Nom, string Prenom, string Adresse, int Permis, bool Pret)
        {
            _nom = Nom;
            _prenom = Prenom;
            _adresse = Adresse;
            _permis = Permis;
            _pret = Pret;
        }
    }
}
