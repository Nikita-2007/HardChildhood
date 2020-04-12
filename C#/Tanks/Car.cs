﻿using System.Drawing;

namespace Tanks
{
    class Car : Unit
    {
        private Bitmap bitmap = new Bitmap(Properties.Resources.Машинка);
        private Rectangle body = new Rectangle(new Point(0, 0), new Size(64, 64));
                      
        //Отрисовка Танка
        public void DrawCar(Graphics g, Point cursor)
        {
            target = cursor;
            Position();
            Vector();            

            //Отрисовка Машинка
            g.TranslateTransform(position.X, position.Y);
            g.RotateTransform(vector);
            g.DrawImage(bitmap, -64, -75, body, GraphicsUnit.Pixel);
            g.ResetTransform();
        }
    }
}