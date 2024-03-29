﻿using System.Drawing;

namespace Tanks
{
    class Tank : Unit, IDrawn
    {
        private static Size size = new Size(128, 128);
        private readonly Bitmap bitmap = new Bitmap(Properties.Resources.Танк);
        private readonly Rectangle body = new Rectangle(new Point(0, 0), size);
        private readonly Rectangle tower = new Rectangle(new Point(128, 0), size);
        private float vectorTower; // Угол поворота башни
        private SolidBrush solidBrush;

        /// <summary>
        /// Конструктор Танка
        /// </summary>
        public Tank(Color color)
        {
            this.color = color;
            speed = 0.5f;
            life = 40;
            vision = 512;
            act = Act.WAIT;
            timeShot = 60;
        }

        //Отрисовка Танка
        public void DrawUnit(Graphics g)
        {
            solidBrush = new SolidBrush(color);
            vectorTower = Vector(vectorTower, speed * 2);
            center = life*80/40-40;

            #region **********************Отрисовка по частям**********************

            //Цвет
            g.TranslateTransform(position.X, position.Y);
            g.RotateTransform(vector);
            g.FillRectangle(solidBrush, -40, -30, 80, 60);

            //Корпус
            g.DrawImage(bitmap, -64, -80, body, GraphicsUnit.Pixel);
            g.ResetTransform();

            //Башня
            g.TranslateTransform(position.X, position.Y);
            g.RotateTransform(vectorTower);
            g.DrawImage(bitmap, -64, -90, tower, GraphicsUnit.Pixel);
            g.ResetTransform();

            DrawInfo(g);
            #endregion
        }
    }
}