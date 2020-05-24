using System.Drawing;

namespace Tanks
{
    class Car : Unit, IDrawn
    {
        private static Size size = new Size(64,64);
        private readonly Bitmap bitmap = new Bitmap(Properties.Resources.Машинка);
        private readonly Rectangle body = new Rectangle(new Point(0, 0), size);
        private SolidBrush solidBrush;

        /// <summary>
        /// Конструктор Машинки
        /// </summary>
        public Car()
        {
            speed = 2;
            life = 10;
        }

        //Отрисовка Машинки
        public void DrawUnit(Graphics g, Point cursor)
        {
            solidBrush = new SolidBrush(color);
            target = cursor;
            PositionUnit();
            vector = Vector(vector, speed=4);

            //Цвет
            g.TranslateTransform(position.X, position.Y);
            g.RotateTransform(vector);
            g.FillRectangle(solidBrush, -12, -16, 20, 56);

            //Отрисовка Машинка

            g.DrawImage(bitmap, -15, -20, body, GraphicsUnit.Pixel);
            g.ResetTransform();


            DrawInfo(g);           
        }
    }
}