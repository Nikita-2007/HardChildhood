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

        //Расчет растояния между точками float
        public float Delta(PointF point1, PointF point2)
        {
            float cathetX = point1.X - point2.X;
            float cathetY = point1.Y - point2.Y;

            return (float)Math.Sqrt(cathetX * cathetX + cathetY * cathetY);

        }
    }
}