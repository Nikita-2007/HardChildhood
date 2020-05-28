using System;
using System.Collections.Generic;
using System.Drawing;

namespace Tanks
{
    class ListUnit
    {
        public Size window = FormTank.window;
        public byte count = 5;
        private Random random = new Random();
        private List<object> listUnits = new List<object>();


        /// <summary>Команда : Пусто/summary>
        public ListUnit()
        {
            Color color = Color.FromArgb(255, Color.FromArgb (random.Next(0xFFFFFF+1)));
            CreateListUnits(color, new Point(50, 50), count, count);
        }

        /// <summary>Команда : Цвет и Позиция</summary>
        public ListUnit(Color color, Point start)
        {
            CreateListUnits(color, start, count, count);
        }

        /// <summary>Позиция танков и машинок : Пусто/summary>
        public ListUnit(Point start, byte tank, byte car)
        {
            Color color = Color.FromArgb(255, Color.FromArgb(random.Next(0xFFFFFF + 1)));
            CreateListUnits(color, start, tank, car);
        }

        /// <summary> Команда: Цвет и Позиция и Число юнитов <summary> \\\
        public ListUnit(Color color, Point start, byte unit)
        {
            CreateListUnits(color, start, unit, unit);
        }

        /// <summary>Цвет: ... Позиция: ... Танки: ... Машинки: ... </summary>
        public ListUnit(Color color, Point start, byte tank, byte car)
        {
            CreateListUnits(color, start, tank, car);
        }


        //создаём список танков и Машинок
        public List<object> CreateListUnits(Color color, Point start, byte tank, byte car)
        {
            for (byte  i = 1; i <= car; i++)
                NewUnit(new Car(color), start);

            for (byte i = 1; i <= tank; i++)
                NewUnit(new Tank(color), start);

            return listUnits;
        }

        //Добовляем юнита в список
        private void NewUnit(dynamic unit, Point start)
        {
            listUnits.Add(unit);
            unit.position = StartPosition(start);
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
            position.Y = window.Height * start.Y / 100 + random.Next(-200, 200);

            return position;
        }
    }
}