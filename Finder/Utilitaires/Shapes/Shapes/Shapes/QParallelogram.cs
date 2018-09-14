using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Shapes
{
    class QParallelogram : Quadrangle
    {
        public int _height;

        public int _width;

        public int _angle;

        public  QParallelogram(Point Position, int height, int width, int angle)
        {
            _height = height;
            _width = width;
            _angle = angle;
        }

        public void Draw(Bitmap bitmap)
        {

            Pen blackPen = new Pen(Color.Black, 3);

            Graphics g = Graphics.FromImage(bitmap);
        }

    }

}
