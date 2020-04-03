using System;
using System.Drawing;

namespace Tanks
{
    class Tank
    {
        public int id; // Я тепя по ID вычеслю
        public PointF position; //Местоположение Танк

        private Bitmap bitmap = new Bitmap(Properties.Resources.Танк);
        private Rectangle body = new Rectangle(new Point(0, 0), new Size(128, 128));
        private Rectangle tower = new Rectangle(new Point(128, 0), new Size(256, 128));
        private float vector; // Угол поворота корпуса
        private float vectorTower; // Угол поворота башни
        private float speed = 1; // скорость
        private Point target; //цель
 
        //Отрисовка Танка
        public void DrawTank(Graphics g, Point cursor)
        {
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

        //Поворот танка
        private float Vector()
        {
            float catetX = target.X - position.X;
            float catetY = target.Y - position.Y;
            vector = (float)(Math.Atan2(catetY, catetX) * 180/Math.PI+90);

            return vector;
        }

        //Позиция танка
        private PointF Position()
        {
            position.X += speed*(float)Math.Cos(vector);
            position.Y += speed*(float)Math.Sin(vector);
            return position;
        }
    }
}