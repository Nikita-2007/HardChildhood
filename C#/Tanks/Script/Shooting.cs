using Game2d;
using System.Collections.Generic;

namespace Tanks
{
    class Shooting
    {
        private ListShot listShot;

        //Расчет стрельбы
        public void ActShot(List<ListUnit> ListParty, ListShot listShot)
        {
            this.listShot = listShot;

            foreach (Shot shot in listShot.listShot)
            {
                shot.MoveShot();
                if (shot.speed < 2)
                    listShot.RemoveShot(shot);
            }
        }
    }
}