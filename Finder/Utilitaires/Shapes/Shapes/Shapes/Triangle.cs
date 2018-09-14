using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Shapes
{
    class Triangle : GeometricShape
    {
        public Point _P2;

        public Point _P3;

        public Triangle()
        {
            
        }

        public Triangle(Point Position, Point P2, Point P3)
        {
            _Position = Position;
            _P2 = P2;
            _P3 = P3;
        }

        public void Draw(Bitmap bitmap)
        {
            Graphics g = Graphics.FromImage(bitmap);

            g.DrawLine(new Pen(Color.Black), _Position, _P2);
            g.DrawLine(new Pen(Color.Black),_P2, _P3);
            g.DrawLine(new Pen(Color.Black),_P3,_Position);
        }

    }
}