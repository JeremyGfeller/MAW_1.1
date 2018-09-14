using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Shapes
{
    class TIsosceles : Triangle
    {
        public int _lenght;
        public int _angle;

        public TIsosceles(int lenght, int angle)
        {
            _lenght = lenght;
            _angle = angle;
        }
        public void Draw(Bitmap bitmap)
        {
            Graphics g = Graphics.FromImage(bitmap);

        }
    }
}
