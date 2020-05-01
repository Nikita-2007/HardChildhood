using System.Drawing;

namespace Tanks
{
    class Car : Unit, IDrawn
    {
        private static Size size = new Size(64,64);
        private readonly Bitmap bitmap = new Bitmap(Properties.Resources.Машинка);
        private readonly Rectangle body = new Rectangle(new Point(0, 0), size);
                      
        //Отрисовка Танка
        public void DrawUnit(Graphics g, Point cursor)
        {
            target = cursor;
            Position();
            vector = Vector(vector, speed*3);            

            //Отрисовка Машинка
            g.TranslateTransform(position.X, position.Y);
            g.RotateTransform(vector);
            g.DrawImage(bitmap, -15, -20, body, GraphicsUnit.Pixel);
            g.ResetTransform();

            DrawInfo(g);
        }
    }
}