using System.Drawing;

namespace Aquarium
{
    class Fish3 : AFish, IFish
    {
        public Bitmap bitmap = Properties.Resources._3fish;

        //Отрисовка Рыбы
        public void DrawFish(Graphics g)
        {
            Target();
            Position(bitmap);
            fish123 = 3;

            g.DrawImage(bitmap, position.X, position.Y);
        }
    }
}