using System.Drawing;

namespace Aquarium
{
    class Fish3 : AFish, IFish
    {
        private Bitmap bitmap = Properties.Resources._3fish;

        //Отрисовка Рыбы
        public void DrawFish(Graphics g)
        {
            g.DrawImage(bitmap, position.X, position.Y);
        }
    }
}