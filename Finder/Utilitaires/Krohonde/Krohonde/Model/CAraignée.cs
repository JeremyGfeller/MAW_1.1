using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krohonde.Model
{
    public class CAraignée:CCréature
    {
        public CAraignée(int x, int y)
            : base(x, y)
        {
            NiveauDeVie = CJardin.LoiDeLaNature("MaxPointsVieAraignée");
            MaxPointsDeVie = CJardin.LoiDeLaNature("MaxPointsVieAraignée");
            Age = CJardin.LoiDeLaNature("MaxPointsVieAraignée");
        }

        public void CycleDeVie(CJardin LeJardin) // Méthode qui fait "vivre" la fourmi un instant (un battement de coeur si on veut)
        {
        }
    }
}
