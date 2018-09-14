using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Krohonde
{
    /// <summary>
    /// La classe dont héritent tous les éléments qui sont visibles dans le jardin: Créatures, Ressources et éléments de décor
    /// </summary>
    public abstract class CChoseVisible
    {
        public int X;                                   // Position dans la grille du jardin
        public int Y;
        public PictureBox controle; // L'image qui représente l'élément
    }
}
