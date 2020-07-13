using System;
using System.Drawing;

namespace Aquarium
{
    class Fish1 : AFish
    {
        private static Size size = new Size(50, 144);
        private Bitmap bitmap;
        private Rectangle fish1 = new Rectangle(new Point(200, 800), size);
        private int x = 1;
        private byte time = 0;


        //Отрисовка Рыбы
        public void DrawFishs1(Graphics g)
        {
            //Рыба
            if (time > 180)
                time = 0;
            if (fish1.X == target.X || fish1.Y == target.Y)
            {
                target = new PointF(
                            random.Next(10, 800),
                            random.Next(10, 900));
            }

            if (target.X > fish1.X)
            {
                fish1.X++;
                bitmap = Properties.Resources._1FishZ;
            }

            else if (time == 0)
            {
                fish1.X--;
                bitmap = Properties.Resources._1Fish;
            }
            if (target.Y > fish1.Y)
                fish1.Y++;
            else
                fish1.Y--;

            if (x < 2)
            {
                target.X = random.Next(0, 1800);
                target.Y = random.Next(10, 900);
                fish1.X = random.Next(0, 600);
                fish1.Y = random.Next(10, 900);
                x++;
            }

            time++;
            g.DrawImage(bitmap, fish1.X, fish1.Y);
            g.ResetTransform();
        }
    }
}