using System.Drawing;

namespace Tanks
{
    class Car : Unit, IDrawn
    {
        private static Size size = new Size(64,64);
        private readonly Bitmap bitmap = new Bitmap(Properties.Resources.Машинка);
        private readonly Rectangle body = new Rectangle(new Point(0, 0), size);
        private Pen pen;

        /// <summary>
        /// Конструктор Машинки
        /// </summary>
        public Car()
        {
            speed = 2;
            life = 10;
        }

        //Отрисовка Танка
        public void DrawUnit(Graphics g, Point cursor)
        {
            target = cursor;
            PositionUnit();
            vector = Vector(vector, speed=4);

            //Отрисовка Машинка
            g.TranslateTransform(position.X, position.Y);
            g.RotateTransform(vector);
            g.DrawImage(bitmap, -15, -20, body, GraphicsUnit.Pixel);
            g.ResetTransform();
            pen = new Pen(color, 2);
            g.DrawEllipse(pen, position.X-10, position.Y-10, 20, 20);

            DrawInfo(g);           
        }
    }
}