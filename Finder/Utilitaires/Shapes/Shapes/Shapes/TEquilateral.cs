using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Shapes
{
    class TEquilateral : Triangle
    {

        public TEquilateral(Point Position)
        {
            _Position = Position;
        }

        public TEquilateral(Point Position, int length)
        {

        }
        public void Draw(Bitmap bitmap)
        {

        }

        public Point Pos
        {
            get;
            set;
        }
    }
}
