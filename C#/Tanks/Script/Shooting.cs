using Game2d;
using System.Collections.Generic;

namespace Tanks
{
    class Shooting
    {
        //Расчет стрельбы
        public void ActShot(List<ListUnit> ListParty, ListShot listShot)
        {
            foreach (Shot shot in listShot.listShot)
            {
                shot.MoveShot();
                float findDelta;
                dynamic findUnit = 1;
                //findDelta = Func2D.Delta(unit.position, findUnit.position);
                //if (shot.speed < 2 || shot.position == )
                //    listShot.RemoveShot(shot);
            }
        }
    }
}