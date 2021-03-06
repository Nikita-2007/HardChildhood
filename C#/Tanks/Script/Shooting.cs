﻿using System.Collections.Generic;

namespace Tanks
{
    class Shooting
    {
        private Shot shot;
        private Bang bang;
        private Cratar cratar;
        private float delta;

        //Расчет стрельбы
        public void ActShot(List<ListUnit> ListParty, ListShot listShot)
        {
            //Перерасчет пуль
            for(int i = 0; i < listShot.listShot.Count; i++)
            {
                shot = listShot.listShot[i];
                shot.MoveShot();            
                if (shot.Delta(shot.position, shot.target) < 32 || shot.speed < 2)                   
                {
                    //Расчет дамага     
                    foreach (ListUnit party in ListParty)
                        foreach (dynamic unit in party.listUnits)
                        {
                            if (unit.act != Act.DEAD)
                            {
                                delta = unit.Delta(shot.position, unit.position);
                                if (delta < 48)
                                    unit.life -= 175 / delta;
                            }
                        }
                    listShot.RemoveShot(shot);
                }
            }

            //Перерасчет Взрывов
            for (int i = 0; i < listShot.listBang.Count; i++)
            {
                bang = listShot.listBang[i];
                if (bang.time > 75)
                    listShot.RemoveBang(bang);
                else 
                    bang.time += 4;
            }
            //Перерасчет Воронок
            for (int i = 0; i < listShot.listCratar.Count; i++)
            {
                cratar = listShot.listCratar[i];
                if (cratar.time > 600)
                    listShot.RemoveCratar(cratar);
                else
                    cratar.time++;
            }
        }
    }
}