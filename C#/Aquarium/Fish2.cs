using System.Drawing;

namespace Aquarium
{
    class Fish2 : AFish, IFish
    {
        public Bitmap bitmap = Properties.Resources._2fish;

        //Отрисовка Рыбы
        public void DrawFish(Graphics g)
        {
            Target();
            Position(bitmap);
            fish123 = 2;

            g.DrawImage(bitmap, position.X, position.Y);
        }
    }
}