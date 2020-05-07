using System;
using System.Drawing;

namespace Tanks
{
    abstract class AObject 
    {
        public Color color; // Цвет
        public PointF position; // Позиция
        public PointF target; // Цель
        public float vector; // Угол поворота корпуса
        public float speed ; // Скорость

        //Позиция
        public PointF Position()
        {
            position.X += speed * (float)Math.Cos(vector);
            position.Y += speed * (float)Math.Sin(vector);

            return position;
        }
    }
}