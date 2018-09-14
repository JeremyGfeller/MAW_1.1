using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Shapes
{
    class QRhombus : Quadrangle
    {
        public int height;

        public int width;

        public QRhombus(Point Position, int height, int width)
        {
            new Point(0, height / 2);
            new Point(width / 2, 0);
            new Point(width, height / 2);
            new Point(width / 2, height);
        }

        public void Draw()
        {
        }
    }
}

