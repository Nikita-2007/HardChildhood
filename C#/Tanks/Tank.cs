using System.Drawing;

namespace Tanks
{
    class Tank : Unit
    {       
        private Bitmap bitmap = new Bitmap(Properties.Resources.Танк);
        private Rectangle body = new Rectangle(new Point(0, 0), new Size(128, 128));
        private Rectangle tower = new Rectangle(new Point(128, 0), new Size(256, 128));       
        private float vectorTower; // Угол поворота башни
 
        //Отрисовка Танка
        public void DrawUnit(Graphics g, Point cursor)
        {
            speed = 1;
            target = cursor;
            Position();
            Vector();
            vectorTower = vector;

            //Корпус
            g.TranslateTransform(position.X, position.Y);
            g.RotateTransform(vector);
            g.DrawImage(bitmap, -64, -75, body, GraphicsUnit.Pixel);
            g.ResetTransform();

            //Башня
            g.TranslateTransform(position.X, position.Y);
            g.RotateTransform(vectorTower);
            g.DrawImage(bitmap, -64, -90, tower, GraphicsUnit.Pixel);
            g.ResetTransform();
        }
    }
}