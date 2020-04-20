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

        //Позиция
        public PointF Position()
        {
            position.X += speed * (float)Math.Cos(vector);
            position.Y += speed * (float)Math.Sin(vector);
            return position;
        }

        //Поворот
        public float Vector()
        {
            float catetX = target.X - position.X;
            float catetY = target.Y - position.Y;
            vector = (float)(Math.Atan2(catetY, catetX) * 180 / Math.PI + 90);

            return vector;
        }
    }
}
