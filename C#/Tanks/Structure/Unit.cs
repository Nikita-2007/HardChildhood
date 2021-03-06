﻿using System;
using System.Drawing;

namespace Tanks
{
    abstract class Unit : AObject
    {
        private static uint ID; 

        public uint id = ++ID;// Я тепя по ID вычеслю
        public Act act; //Логика
        public float life; // Это жизнь
        public float vision; //Дальность обзора
        public sbyte timeShot;
        private Font font = new Font("Areal", 16, FontStyle.Bold, GraphicsUnit.Point);
        private SolidBrush color = new SolidBrush(Color.Black);
        private Pen penG = new Pen(Color.Chartreuse, 5);
        private Pen penR = new Pen(Color.Maroon, 5);
        private float angle;
        public float center;

        //Номер и полоска жизини
        public void DrawInfo(Graphics g)
        {
            if (life <= 0)
                life = 0;
            //ID
            g.TranslateTransform(position.X, position.Y);
            g.DrawString(life.ToString(), font, color, -10, -50);
            g.ResetTransform();
            //Полоска жизни
            g.TranslateTransform(position.X, position.Y);           
            g.DrawLine(penG, -40, 40, center, 40);
            g.DrawLine(penR, center, 40, 40, 40);
            g.ResetTransform();
        }

        //Поворот
        public float Vector(float vector, float speed)
        {
            // угол на цель
            float catetX = target.X - position.X;
            float catetY = target.Y - position.Y;
            angle = (float)(Math.Atan2(catetY, catetX) * 180 / Math.PI + 90);
            if (angle < 0) angle += 360;

            //текущий угол
            if (Math.Abs(vector - angle) > speed) 
            {
                if ((vector < angle && (angle - vector) < 180) ^ (angle - vector) > -180)
                    vector = (vector - speed+360)%360;
                else
                    vector = (vector + speed)%360;
            }
            else
                vector = angle;
            

            return vector;
        }

        //Позиция
        public PointF PositionUnit()
        {
            if (vector == angle)
                position = Position();

            return position;
        }
    }
}