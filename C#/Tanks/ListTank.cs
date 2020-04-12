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
        private List<Car> listCar = new List<Car>();

        //создаём список танков
        public List<Tank> CreateListTank()
        {
            for (byte  i = 1; i <= count; i++)
            {
                listTanks.Add(new Tank
                {
                    id = i,
                    position = StartPosition()
                });
            }
            return listTanks;
        }

        //создаём список Машинок
        public List<Car> CreateListCar()
        {
            for (byte i = 1; i <= count; i++)
            {
                listCar.Add(new Car
                {
                    id = i,
                    position = StartPosition()
                });
            }
            return listCar;
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

        // отрисовка списка Машинок 
        public void DrawListCar(Graphics g, Point cursor)
        {
            foreach (Car car in listCar)
            {
                car.DrawCar(g, cursor);
            }
        }
    }
}