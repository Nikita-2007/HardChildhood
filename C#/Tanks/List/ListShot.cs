using System.Collections.Generic;
using System.Drawing;

namespace Tanks
{
    class ListShot
    {
        public List<Shot> listShot = new List<Shot>();
        public List<Bang> listBang = new List<Bang>();
        public List<Cratar> listCratar = new List<Cratar>();

        // Добовляем выстрел
        public void NewShot(dynamic unit)
        {
            listShot.Add(new Shot(unit));
        }

        //Удаление выстрела
        public void RemoveShot(Shot shot)
        {            
            listBang.Add(new Bang(shot.position));
            listShot.Remove(shot);
        }

        //Удаление Взрыва
        public void RemoveBang(Bang bang)
        {
            listCratar.Add(new Cratar(bang.position));          
            listBang.Remove(bang);
        }

        //Удаление Кратора
        public void RemoveCratar(Cratar cratar)
        {
            listCratar.Remove(cratar);
        }

            //Отрисовываем краторы
        public void DrawListCratar(Graphics g)
        {
        foreach (Cratar сratar in listCratar)
            сratar.DrawCratar(g);
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