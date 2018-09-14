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
    public partial class frmShapes : Form
    {
        System.Drawing.Bitmap bitmap;
        // Circle MyCircle = new Circle(new Point(100,100), 100);
        // Triangle MyTriangle = new Triangle(new Point(10,10), new Point(10,590), new Point(790,10));

        public frmShapes()
        {
            InitializeComponent();
        }

        private void cmdDessiner_Click(object sender, EventArgs e)
        {
            bitmap = new System.Drawing.Bitmap(800, 600);
            picCanevas.Image = bitmap;
            Graphics g = Graphics.FromImage(bitmap);

            QSquare MyQSquare = new QSquare(new Point(200, 200), 200);
            MyQSquare.Draw(bitmap);
            QSquare MyQSquare2 = new QSquare(new Point(240, 240), 35);
            MyQSquare2.Draw(bitmap);
            QSquare MyQSquare3 = new QSquare(new Point(325, 240), 35);
            MyQSquare3.Draw(bitmap);
            QSquare MyQSquare4 = new QSquare(new Point(270, 310), 30);
            MyQSquare4.Draw(bitmap);
            QSquare MyQSquare5 = new QSquare(new Point(300, 310), 30);
            MyQSquare5.Draw(bitmap);
            QSquare MyQSquare6 = new QSquare(new Point(315, 340), 30);
            MyQSquare6.Draw(bitmap);
            QSquare MyQSquare7 = new QSquare(new Point(255, 340), 30);
            MyQSquare7.Draw(bitmap);

            // MyCircle.Draw(bitmap);
            // MyTriangle.Draw(bitmap);
            picCanevas.Invalidate();
        }
    }
}
