using System;
using System.Collections.Generic;
using System.Drawing;

namespace Tanks
{
    class ListUnit
    {
        public Size window = FormTank.window;
        public byte count = 10;
        private Random random = new Random();
        private List<object> listUnits = new List<object>();

        /// <summary>Команда : Пусто/summary>
        public ListUnit()
        {
            Color color = Color.FromArgb(255, Color.FromArgb (random.Next(0xFFFFFF+1)));
            CreateListUnits(color, new Point(50, 50));
        }

        /// <summary>Команда : Цвет и Позиция</summary>
        public ListUnit(Color color, Point start)
        {
            CreateListUnits(color, start);
        }

        //создаём список танков и Машинок
        public List<object> CreateListUnits(Color color, Point start)
        {
            for (byte  i = 1; i <= count; i++)
            {
                listUnits.Add(new Tank
                {
                    color = color,
                    position = StartPosition(start),                  
                });

                listUnits.Add(new Car
                {
                    color = color,
                    position = StartPosition(start),                   
                });
            }
            return listUnits;
        }       

        // отрисовка списка танков и машинок
        public void DrawListUnit(Graphics g, Point cursor, ListShot listShot)
        {
            foreach (dynamic unit in listUnits)
            {
                unit.DrawUnit(g, cursor);

                unit.timeShot++;
                if (unit.timeShot > 120)
                {
                    listShot.NewShot(unit);
                    unit.timeShot = 0;
                }

            }
        }

        //Стартовая позиция танка и мошинок
        private Point StartPosition(Point start)
        {
            Point position = new Point();
            position.X = window.Width * start.X / 100 + random.Next(-200, 200);
            position.Y = window.Height * start.X / 100 + random.Next(-200, 200);

            return position;
        }
    }
}