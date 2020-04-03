using System;
using System.Collections.Generic;
using System.Drawing;

namespace Tanks
{
    class ListTank : List<Tank>
    {
        public byte count = 10;
        private Random random = new Random();
        private List<Tank> listTanks = new List<Tank>();

        //создаём список танков
        public List<Tank> CreateListTank()
        {
            for (byte  i = 1; i <= count; i++)
            {
                listTanks.Add(new Tank()
                {
                    id = i,
                    position = StartPosition()
                });
            }
            return listTanks;
        }

        //Стартовая позиция танка
        private Point StartPosition()
        {
            Point position = new Point();
            position.X = random.Next(1280);
            position.Y = random.Next(720);
            return position;
        }

        // отрисовка списка танков 
        public void DrawListTank(Graphics g, Point cursor)
        {
            foreach (Tank tank in listTanks)
            {
                tank.DrawTank(g, cursor);
            }
        }
    }
}