using System;
using System.Drawing;
using System.Reflection.Emit;

namespace Aquarium
{
    abstract class AFish
    {
        public PointF position = new PointF();
        public PointF target = new PointF();
        public int fish123;
        public PointF bposition = new PointF();

        private Random random = new Random();
        private byte x = 1;
        private byte time1 = 0;

        //Расчет Позиции
        public PointF Position(Bitmap bitmap)
        {
            if (time1 == 60)
                time1 = 0;


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
            bposition.X = position.X;
            bposition.Y = position.Y;
            time1++;

            return position;
        }

        public PointF PositionBubble(Bitmap bitmap)
        {
            position.X = bposition.X + 100;
            position.Y = bposition.Y + 500;

            return position;
        }

        //Расчeт цели
        public PointF Target()
        {
            if (Math.Abs(position.X - target.X) < 2 && Math.Abs(position.Y - target.Y) < 2)
            {
                target.X = random.Next(0, 1800);
                target.Y = random.Next(0, 1080);
            }
            return target;
        }
    }
}