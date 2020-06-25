using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace Tanks
{
    class ListShot
    {
        public List<Shot> listShot = new List<Shot>();

        // Добовляем выстрел
        async public void NewShot(dynamic unit)
        {
            listShot.Add(new Shot(unit));
            await Task.Run(() => Console.Beep(300,50));
        }

        //Удаление выстрела
        public void RemoveShot(Shot shot)
        {
            listShot.Remove(shot);
        }

        //Отрисовываеи лист пулек
        public void DrawListShot(Graphics g)
        {
            foreach (Shot shot in listShot)
            {
                shot.DrawShot(g);
            }
        }
    }
}