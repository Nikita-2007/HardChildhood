using System.Drawing;

namespace Aquarium
{
    class Fish1 : AFish, IFish
    {
        private Bitmap bitmap = Properties.Resources._1Fish;

        //Отрисовка Рыбы
        public void DrawFish(Graphics g)
        {
            g.DrawImage(bitmap, position.X, position.Y);
        }
    }
}