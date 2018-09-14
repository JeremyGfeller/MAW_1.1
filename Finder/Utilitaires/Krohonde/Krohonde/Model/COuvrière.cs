using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Krohonde
{
    public class COuvrière : CCréature
    {
        public int NiveauSacMatériau = 0; // Quantité de matériau transportée

        public COuvrière(int x, int y)
            : base(x, y)
        {
            NiveauDeVie = CJardin.LoiDeLaNature("MaxPointsVieFourmi");
            MaxPointsDeVie = CJardin.LoiDeLaNature("MaxPointsVieFourmi");
            Age = CJardin.LoiDeLaNature("MaxPointsVieFourmi");
            DirectionMouvement = CJardin.Direction.Nord;
        }

        public void CycleDeVie(CJardin LeJardin) // Méthode qui fait "vivre" la fourmi un instant (un battement de coeur si on veut)
        {
            LeJardin.BougerCréature(this);
        }

    }
}
