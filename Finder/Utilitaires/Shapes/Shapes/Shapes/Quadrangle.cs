using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Shapes
{
    class Quadrangle : GeometricShape
    {
        public Point _P2;

        public Point _P3;

        public Point _P4;

        public Quadrangle()
        { }

        public Quadrangle (Point Position, Point P2, Point P3, Point P4)
        {
            this._P2 = new Point(200,200);
            this._P3 = new Point(250,250);
            this._P4 = new Point(300,300);
        }

        public void Draw(Bitmap bitmap)
        {
            //Graphics g = Graphics.FromImage(bitmap);
            //g.DrawRectangle(new Pen(Color.Black), 30, 30, 500, 50);
        }
    }
}
