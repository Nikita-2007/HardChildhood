﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace Tanks
{
    class ListUnit
    {
        public byte count = 10;
        private Random random = new Random();
        private List<object> listUnits = new List<object>();
        
        //создаём список танков и Машинок
        public List<object> CreateListUnits()
        {
            for (byte  i = 1; i <= count; i++)
            {
                listUnits.Add(new Tank
                {
                    id = i,
                    position = StartPosition()
                });

                listUnits.Add(new Car
                {
                    id = i,
                    position = StartPosition()
                });
            }
            return listUnits;
        }       

        // отрисовка списка танков 
        public void DrawListUnit(Graphics g, Point cursor)
        {
            foreach (dynamic unit in listUnits)
            {
                unit.DrawUnit(g, cursor);
            }
        }

        //Стартовая позиция танка
        private Point StartPosition()
        {
            Point position = new Point();
            position.X = random.Next(1280);
            position.Y = random.Next(720);
            return position;
        }
    }
}