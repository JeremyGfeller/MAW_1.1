using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Shapes
{
    class TRectangle : Triangle
    {
        public int height;

        public int width;

        public TRectangle(Point Position, int pheight, int pwidth) //Rappelle de la postition, la hauteur et la largeur 
        {
            _Position = Position;
            height = pheight;
            width = pwidth;
        }

        public void Draw(Bitmap bitmap) //Où va se dessiner la forme 
        {
            Graphics g = Graphics.FromImage(bitmap);
            // Create pen
            Pen blackPen = new Pen(Color.Red, 3);

            //Création des points pour notre Triangle
            Point point1 = _Position;                                    //Définition du point de départ
            Point point2 = new Point(_Position.X, _Position.Y + height);  //Point de départ + la hauteur
            Point point3 = new Point(_Position.X + width, _Position.Y);   //Point de départ + la largeur
            Point[] curvePoints =                                       //Stockage des points dans un tableau
                         {
                             point1, 
                             point2,
                             point3,
                         };

            // Draw polygon to screen.
            g.DrawPolygon(blackPen, curvePoints);
        }
    }
}
