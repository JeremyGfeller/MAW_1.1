using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Shapes
{
    class QRectangle : GeometricShape
    {
       public int height;

	
        public int width;

       
       
        public QRectangle()
        {


        }

         public QRectangle(Point pPosition, int pheight, int pwidth)
         {
             _Position = pPosition;
             height = pheight;
             width = pwidth;
         }

         public void Draw(Bitmap bitmap)
         {
             Graphics g = Graphics.FromImage(bitmap);
             g.DrawRectangle(new Pen(Color.HotPink), _Position.X, _Position.Y, width, height);
         }
    }

   
}

