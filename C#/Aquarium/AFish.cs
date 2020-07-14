using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aquarium
{
    abstract class AFish
    {
        public PointF position = new PointF();
        public PointF target = new PointF();

        private Random random = new Random();

        //Расчет Позиции
        public PointF Position()
        {
            if (target.X > position.X)
            {
                position.X++;
            }
            else
            {
                position.X--;
            }

            if (target.Y > position.Y)
                position.Y++;
            else
                position.Y--;


            return position;
        }

        //Расчeт цели
        public PointF Target()
        {
            if (position.X == target.X || position.Y == target.Y)
            {
                target.X = random.Next(0, 1920);
                target.Y = random.Next(0, 1000);
            }
            return target;
        }
    }
}