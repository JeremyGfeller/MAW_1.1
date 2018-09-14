using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Krohonde
{
    /// <summary>
    /// Les fourmis fermières ont pour seule fonction de ramener de la nourriture ou des matériaux de construction dans la fourmilière
    /// </summary>
    public class CFermière : CCréature
    {
        private Random alea = new Random();

        public int NiveauSacNourriture; // Quantité de nourriture transportée
        public int NiveauSacMatériau; // Quantité de matériau transportée
        public CFermière(int x, int y)
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


