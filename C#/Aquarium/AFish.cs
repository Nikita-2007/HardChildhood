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
        private byte time1 = 0;
        private int time2 = 0;

        //Расчет Позиции
        public PointF Position(Bitmap bitmap)
        {
            if (time1 == 60)
                time1 = 0;

            if (time2 >= 180)
                time2 = 0;

            if (target.X > position.X)
            {
                if (x == 1 && time1 == 0)
                {
                    bitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    x = 2;
                }
                position.X++;
            }
            else
            {
                if (x == 2 && time1 == 0)
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
            time1++;
            time2 += random.Next(-10, 10);
            time2++;

            return position;
        }

        //Расчeт цели
        public PointF Target()
        {
            if (position.X == target.X && position.Y == target.Y || time2 >= 160)
            {
                target.X = random.Next(0, 1800);
                target.Y = random.Next(0, 1080);
            }

            return target;           
        }
    }
}