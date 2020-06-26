using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace Tanks
{
    class ListShot
    {
        public List<Shot> listShot = new List<Shot>();
        public List<Bang> listBang = new List<Bang>();

        // Добовляем выстрел
        async public void NewShot(dynamic unit)
        {
            listShot.Add(new Shot(unit));
            await Task.Run(() => Console.Beep(300,50));
        }

        //Удаление выстрела
        async public void RemoveShot(Shot shot)
        {
            await Task.Run(() => Console.Beep(100, 100));
            listBang.Add(new Bang(shot.position));
            listShot.Remove(shot);
        }

        //Отрисовываеи лист пулек и взрывов
        public void DrawListShot(Graphics g)
        {
            foreach (Shot shot in listShot)
                shot.DrawShot(g);
            foreach (Bang bang in listBang)
                bang.DrawBang(g);
        }
    }
}