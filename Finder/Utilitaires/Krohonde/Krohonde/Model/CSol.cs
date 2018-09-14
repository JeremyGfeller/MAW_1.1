using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krohonde
{
    public class CSol
    // Classe regroupant les éléments qui constituent le sol du jardin: Herbe, Rocher, Fourmilière, Dépôt
    {
        public int X; // Position
        public int Y;
        public CJardin.Elément TypeElément;
        public string NomControle = ""; // Nom du contrôle (picture box) représentant l'objet

        public CSol(int px, int py, CJardin.Elément ptype)
        {
            X = px;
            Y = py;
            TypeElément = ptype;
            NomControle = ptype.ToString() + CJardin.IDContrôle++.ToString();
        }

    }

}
