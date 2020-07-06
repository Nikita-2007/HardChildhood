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
        public Shot(dynamic unit)
        {          
            color = unit.color;
            pen = new Pen(color, 3);
            position = unit.position;
            target = unit.target;
            vector = (float)Math.Atan2(unit.target.Y - unit.position.Y,
            unit.target.X - unit.position.X);
            speed = 16;
            Sound.Shot();
        }
        
        //Расчот палёта Пульки
        public void MoveShot()
        {
            position0 = position;
            position = Position();
            speed *= 0.979542378146892f;
        }

        //Отрисовка Пульки
        public void DrawShot(Graphics g)
        {
            g.DrawLine(pen, position, position0);
        }
    }
}