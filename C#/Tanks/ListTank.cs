using System.Collections.Generic;
using System.Drawing;

namespace Tanks
{
    class ListTank : List<Tank>
    {
        Tank tank = new Tank();
        List<Tank> listTanks = new List<Tank>();


        //создаём список танков
        public List<Tank> CreateListTank()
        {
            for (byte  i = 1; i <= 10; i++)
            {
                listTanks.Add(new Tank()
                {
                    id = i,
                    position = tank.Position()
                });
            }
            return listTanks;
        }

        // отрисовка списка танков
        public void DrawListTank(Graphics g)
        {
            foreach (Tank tank in listTanks)
            {
                tank.DrawTank(g);
            }
        }
    }
}