using System;
using System.Drawing;

namespace Tanks
{
    class Shot : AObject
    {
        private Pen pen;
        private PointF position0;

        /// <summary>
        /// Конструктор снаряда
        /// </summary>
        public Shot()
        {
            speed = 16;
        }

        //Отрисовка Пульки
        public void DrawShot(Graphics g)
        {
            position0 = position;
            position = Position();
            pen = new Pen(color, 3);
            g.DrawLine(pen, position, position0);
        }
    }
}