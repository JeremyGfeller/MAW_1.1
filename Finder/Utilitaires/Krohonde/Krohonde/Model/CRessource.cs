using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krohonde
{
    public class CRessource:CChoseVisible
    // Classe incluant les éléments que Mère Nature fait évoluer: Larves, Nourriture, Matériau, Phéromones
    {
        public CJardin.Elément TypeRessource;
        public int Niveau;

        public CRessource(int px, int py, CJardin.Elément ptype)
        {
            X = px;
            Y = py;
            TypeRessource = ptype;
            if ((ptype >= CJardin.Elément.PhéroSoldat) &&(ptype <= CJardin.Elément.PhéroFermière)) 
                Niveau = 8;
            else
                Niveau = 1;
        }
    }
}
