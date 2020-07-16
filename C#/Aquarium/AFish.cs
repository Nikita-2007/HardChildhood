using System;
using System.Drawing;

namespace Aquarium
{
    abstract class AFish
    {
        public PointF position = new PointF();
        public PointF target = new PointF();

        private Random random = new Random();       
        private byte x = 1;

        //Расчет Позиции
        public PointF Position(Bitmap bitmap)
        {            
            if (target.X > position.X)
            {
                if (x == 1)
                {
                    bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    x = 2;
                }
                position.X ++;
            }
            else
            {
                if (x == 2)
                {
                    bitmap.RotateFlip(RotateFlipType.Rotate180FlipY);
                    x = 1;
                }
                position.X --;
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
                target.X = random.Next(0, 1800);
                target.Y = random.Next(0, 1080);
            }
            return target;
        }
    }
}