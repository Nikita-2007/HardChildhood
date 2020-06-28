using System.Collections.Generic;

namespace Tanks
{
    class Shooting
    {
        private Shot shot;
        private Bang bang;
        private Cratar cratar;

        //Расчет стрельбы
        public void ActShot(List<ListUnit> ListParty, ListShot listShot)
        {
            //Перерасчет пуль
            for(int i = 0; i < listShot.listShot.Count; i++)
            {
                shot = listShot.listShot[i];
                shot.MoveShot();
                if (shot.speed < 2)
                    listShot.RemoveShot(shot);
            }

            //Перерасчет Взрывов
            for (int i = 0; i < listShot.listBang.Count; i++)
            {
                bang = listShot.listBang[i];
                if (bang.time > 75)
                    //***************************************  Расчот дамага  ***************************************
                    listShot.RemoveBang(bang);
                else bang.time += 4;
            }
        }
    }
}