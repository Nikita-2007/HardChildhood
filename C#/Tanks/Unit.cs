using System;
using System.Drawing;

namespace Tanks
{
    abstract class Unit
    {
        public int id; // Я тепя по ID вычеслю
        public PointF position; //Местоположение Танк
        public float vector; // Угол поворота корпуса
        public float speed = 2; // скорость
        public Point target; //цель

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
