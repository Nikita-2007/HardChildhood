using System.Drawing;

namespace Aquarium
{
    class Babble : AFish
    {
        public Bitmap bitmap = Properties.Resources.buble;

        //Отрисовка Рыбы
        public void DrawFish(Graphics g)
        {
            PositionBubble(bitmap);

            g.DrawImage(bitmap, position.X, position.Y);
        }
    }
}
