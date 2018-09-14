using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Krohonde
{
    public class CDécor:CChoseVisible
    // Classe regroupant les éléments qui constituent le sol du jardin: Herbe, Rocher, Fourmilière, Dépôt
    {
        public CJardin.Elément TypeElément;

        public CDécor(int px, int py, CJardin.Elément ptype)
        {
            X = px;
            Y = py;
            TypeElément = ptype;
        }

    }

}
