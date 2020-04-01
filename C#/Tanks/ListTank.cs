using System.Drawing;

namespace Tanks
{
    class ListTank
    {
        Tank tank;

        public void DrawListTank(Graphics g)
        {
            for (int i = 0; i < 10; i++)
            {
                tank = new Tank();
                tank.DrawTank(g);
            }
        }
    }
}