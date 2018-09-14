using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krohonde
{
    /// <summary>
    /// Classe de base pour l'araignée et tous les types de fourmi (ouvrière, fermière, scout, soldat)
    /// </summary>
    /// \author X. Carrel
    /// \version 1.1
    /// \date Janvier 2016
    public class CCréature:CChoseVisible
    {
        public CJardin.Direction DirectionMouvement;    // Direction dans laquelle la créature est tournée
        public int MaxPointsDeVie;                      // Nombre maximum de points de vie. Ce nombre va baisser quand la créature vieillit
        public int NiveauDeVie;                         // Nombre de points de vie actuel
        public int Age;
        public bool AJoué;                              // Sert à s'assurer que chaque créature ne joue qu'une fois par cycle

        public CCréature(int x, int y)
        {
            X = x;
            Y = y;
            DirectionMouvement = CJardin.Direction.Aucune;
        }
    }

}
