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
        
        //создаём список танков и Машинок
        public List<object> CreateListUnits(Color color, int x)
        {
            for (byte  i = 1; i <= count; i++)
            {
                listUnits.Add(new Tank
                {
                    color = color,
                    position = StartPosition(x),
                    speed = 1
                });

                listUnits.Add(new Car
                {
                    color = color,
                    position = StartPosition(x),
                    speed = 2
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
                listShot.NewShot(unit);
            }
        }

        //Стартовая позиция танка и мошинок
        private Point StartPosition(int x)
        {
            Point position = new Point();
            position.X = window.Width * x / 100 + random.Next(-200, 200);
            position.Y = random.Next(0, window.Height);

            return position;
        }
    }
}