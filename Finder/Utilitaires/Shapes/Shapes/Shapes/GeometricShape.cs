using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Shapes
{
    public class GeometricShape
    {
        public Color _LineColor;
        public Color _FillColor;
        public Point _Position;

        public GeometricShape()
        {
            _LineColor = Color.Aquamarine;
            _FillColor = Color.BurlyWood;
            _Position = new Point(10, 10);
        }
    }
}
