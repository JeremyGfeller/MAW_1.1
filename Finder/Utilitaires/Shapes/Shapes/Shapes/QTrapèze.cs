using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Shapes
{
    class QTrapeze : Quadrangle
    {
        public int _height;

        public int _width;

        public int _angle;

        public QTrapeze(Point Position, int height, int width, int angle) : base()
        {
            _height = height;
            _width = width;
            _angle = angle;

        }

        public void Draw(Bitmap bitmap)
        {
            Graphics g = Graphics.FromImage(bitmap);
            Point point1 = _Position;
            // g.DrawPolygon(new Pen(Color.Black),_Position, _height,_width,_angle);
          
        }

    }
}
