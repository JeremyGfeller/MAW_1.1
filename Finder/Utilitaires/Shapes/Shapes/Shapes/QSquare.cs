using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;



namespace Shapes
{
    /// \auteur Alexandre Junod
    /// \date 18.09.2015
    /// \version 1.0
    /// \description Dessine un carré selon les mesures choisies, le point de départ est "Haut - Gauche"
    /// <summary>
    /// Dessin d'un carré
    /// </summary>
    class QSquare : Quadrangle
    {
        public int _length;

        public QSquare(Point Position, int length)
        {
            _length = length;
            _Position = Position;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bitmap">Dessine sur une partie du bitmap choisis</param>
        public void Draw(Bitmap bitmap)
        {
            Graphics g = Graphics.FromImage(bitmap);

            Pen pen = new Pen(Color.Black, 2);
            g.DrawRectangle(pen, _Position.X, _Position.Y, _length, _length);
            pen.Dispose();
        }
    }
}
