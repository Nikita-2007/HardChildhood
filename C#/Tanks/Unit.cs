using System;
using System.Drawing;

namespace Tanks
{
    abstract class Unit
    {
        private static uint ID; 

        public uint id = ++ID;// Я тепя по ID вычеслю
        public PointF position; //Местоположение Танк
        public float vector; // Угол поворота корпуса
        public float speed = 2; // скорость
        public Point target; //цель
        private Font font = new Font("Areal", 16, FontStyle.Bold, GraphicsUnit.Point);
        private SolidBrush color = new SolidBrush(Color.Black);
        private Pen pen = new Pen(Color.Chartreuse, 5);
        private float angle;

        //Номер и полоска жизини
        public void DrawInfo(Graphics g)
        {
            //ID
            g.TranslateTransform(position.X, position.Y);
            g.DrawString(id.ToString(), font, color, -10, -50);            
            g.ResetTransform();
            //Полоска жизни
            g.TranslateTransform(position.X, position.Y);
            g.DrawLine(pen, -30, 30, 40, 30);
            g.ResetTransform();
        }

        //Поворот
        public float Vector()
        {
            // угол на цель
            float catetX = target.X - position.X;
            float catetY = target.Y - position.Y;
            angle = (float)(Math.Atan2(catetY, catetX) * 180 / Math.PI + 90);
            if (angle < 0) angle += 360;

            //текущий угол
            if (Math.Abs(vector - angle) > speed) 
            {
                if ((vector < angle && (angle - vector) < 180) ^ (angle - vector) > -180)
                    vector = (vector - speed+360)%360;
                else
                    vector = (vector + speed)%360;
            }
            else
                vector = angle;
            

            return vector;
        }

        //Позиция
        public PointF Position()
        {
            if (vector == angle)
            {
                position.X += speed * (float)Math.Cos(vector);
                position.Y += speed * (float)Math.Sin(vector);
            }
            return position;
        }
    }
}