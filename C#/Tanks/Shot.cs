using System;
using System.Drawing;

namespace Tanks
{
    class Shot : AObject
    {
        private Pen pen;
        private PointF position0;

        //Отрисовка Пульки
        public void DrawShot(Graphics g)
        {
            position = Position();
            pen = new Pen(Color.DarkOrange, 3);
            g.DrawLine(pen, position, position0);
        }

        //Позиция
        public PointF Position()
        {
            vector = Vector();
            position0 = position;
            position.X += speed * (float)Math.Cos(vector);
            position.Y += speed * (float)Math.Sin(vector);

            return position;          
        }

        // угол на цель
        private  float Vector()
        {
            float catetX = target.X - position.X;
            float catetY = target.Y - position.Y;
            vector = (float)(Math.Atan2(catetY, catetX) * 180 / Math.PI + 90);
            if (vector < 0) vector += 360;

            return vector;
        }
    }
}
