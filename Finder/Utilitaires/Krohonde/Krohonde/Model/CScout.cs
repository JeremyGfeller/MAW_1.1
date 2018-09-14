using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Krohonde
{
    /// <summary>
    /// Les fourmis scouts ont pour seule fonction de repérer de la nourriture, des matériaux de construction ou l'araignée et de déposer des phéromones pour attirer les fermières ou les soldats
    /// </summary>
    public class CScout : CCréature
    {
        public CScout(int x, int y)
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