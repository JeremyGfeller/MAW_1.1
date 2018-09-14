using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shapes
{
    class Oval : GeometricShape
    {
        public int _height;

        public int _width;

        ///  
        public Oval(Point Position, int height, int width)
        {
            _Position = Position;

            _height = height;

            _width = width;

        }

        public void Draw(Bitmap bitmap)
        {

            Graphics g = Graphics.FromImage(bitmap);
            g.DrawEllipse(new Pen(Color.Black),_Position.X, _Position.Y, _width,_height);

        }

    }
}
