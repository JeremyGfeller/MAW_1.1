using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krohonde
{
    /// <summary>
    /// Les fourmis soldat ont pour fonction de combattre l'araignée.
    /// </summary>
    public class CSoldat:CCréature
    {
        public CSoldat(int x, int y)
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
