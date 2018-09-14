//Leandro Jardim 11.09.2015 
// Créaction d'un cercle 
/////////////////////////////

using System.Drawing;
namespace Shapes
{
    class Circle : GeometricShape
    {
        public int _radius ;


        ///  
        public Circle(Point Position, int radius)//methode constructeur 
            : base() // 
        {
            _radius = radius;
            _Position = Position ;
        }

        public void Draw(Bitmap bitmap) // dessiner dans un bitmap
        {

            Graphics g = Graphics.FromImage(bitmap);
            g.DrawEllipse(new Pen(Color.Black), 200, 300, 200, 200);// taille et position du cercle

        }

    }
}
