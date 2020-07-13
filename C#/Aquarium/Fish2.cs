using System;
using System.Drawing;

namespace Aquarium
{
    class Fish2 : AFish
    {
        private static Size size = new Size(200, 109);
        private Bitmap bitmap = new Bitmap(Properties.Resources._2fish);
        private Rectangle fish2 = new Rectangle(new Point(1800, 150), size);
        int x = 1;
        public byte time = 0;


        //Отрисовка Рыбы
        public void DrawFishs2(Graphics g)
        {
            //Рыба
            if (time > 180)
                time = 0;
            if (fish2.X == target.X || fish2.Y == target.Y)
            {
                target.X = random.Next(200, 1800);
                target.Y = random.Next(100, 900);
            }

            if (target.X > fish2.X)
            {
                fish2.X++;
                bitmap = Properties.Resources._2FishZ;
            }

            else if (time == 0)
            {
                fish2.X--;
                bitmap = Properties.Resources._2fish;
            }
            if (target.Y > fish2.Y)
                fish2.Y++;
            else
                fish2.Y--;

            if (x < 2)
            {
                target.X = random.Next(200, 1800);
                target.Y = random.Next(20, 900);
                fish2.X = random.Next(600, 1200);
                fish2.Y = random.Next(10, 900);
                x++;
            }

            time++;
            g.DrawImage(bitmap, fish2.X, fish2.Y);
            g.ResetTransform();
        }
    }
}