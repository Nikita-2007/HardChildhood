using System;
using System.Drawing;

namespace Aquarium
{
    class Fish3 : AFish
    {
        private static Size size = new Size(175, 111);
        private Bitmap bitmap = new Bitmap(Properties.Resources._3fish);
        private Rectangle fish3 = new Rectangle(new Point(1000, 500), size);
        int x = 1;
        private byte time = 0;

        //Отрисовка Рыбы
        public void DrawFishs3(Graphics g)
        {
            //Рыба
            if (time > 180)
                time = 0;
            if (fish3.X == target.X || fish3.Y == target.Y)
            {
                target.X = random.Next(200, 1900);
                target.Y = random.Next(100, 700);
            }

            if (target.X > fish3.X)
            {
                fish3.X++;
                bitmap = Properties.Resources._3fishZ;
            }

            else if (time == 0)
            {
                fish3.X--;
                bitmap = Properties.Resources._3fish;
            }
            if (target.Y > fish3.Y)
                fish3.Y++;
            else
                fish3.Y--;

            if (x < 2)
            {
                target.X = random.Next(0, 1800);
                target.Y = random.Next(30, 900);
                fish3.X = random.Next(1200, 1800);
                fish3.Y = random.Next(10, 900);
                x++;
            }

            time++;
            g.DrawImage(bitmap, fish3.X, fish3.Y);
            g.ResetTransform();
        }
    }
}