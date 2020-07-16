using System.Drawing;

namespace Aquarium
{
    class Fish1 : AFish, IFish
    {
        public Bitmap bitmap = Properties.Resources._1Fish;

        //Отрисовка Рыбы
        public void DrawFish(Graphics g)
        {
            Target();
            Position(bitmap);

            g.DrawImage(bitmap, position.X, position.Y);
        }
    }
}