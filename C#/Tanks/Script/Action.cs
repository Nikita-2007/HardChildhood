using System.Collections.Generic;
using System.Drawing;
using Game2d;

namespace Tanks
{
    class Action
    {
        private List<ListUnit> ListParty;
        private ListShot listShot;

        //Перебор всех юнитов
        public void ActUnit(List<ListUnit> ListParty, ListShot listShot)
        {
            this.ListParty = ListParty;
            this.listShot = listShot;

            foreach (ListUnit party in ListParty)
                foreach (dynamic unit in party.listUnits)
                    if (unit.act != Act.DEAD) Logic(unit);
        }

        //Логика
        public void Logic(dynamic unit)
        {
            {
                switch (unit.act)
                {
                    case Act.WAIT:
                        ActWAIT(unit);
                        break;

                    case Act.FIND:
                        ActFIND(unit);
                        break;

                    case Act.MOVE:
                        ActMOVE(unit);
                        break;

                    case Act.FIRE:
                        ActFIRE(unit);
                        break;

                    default:
                        unit.Act = Act.WAIT;
                        break;
                }
            }
        }

        //Процес ожидания
        private void ActWAIT(dynamic unit)
        {
            //Если танк мёртв
            if (unit.life <= 0)
                unit.act = Act.DEAD;

            //Если надо найти танк
            else
                ActFIND(unit);
            unit.act = Act.FIRE;
        }

        //Процес поиска
        private void ActFIND(dynamic unit)
        {
            //Юнит едит пока не найдёт цель, башня прямо, через 1 секунду - WAIT
            FindTarget(unit);
        }

        //Процес сближения
        private void ActMOVE(dynamic unit)
        {
            //Юнит едит, башня на цель, когда сможет стрелять - FIRE
        }

        //Процес атаки
        private void ActFIRE(dynamic unit)
        {
            unit.PositionUnit();
            unit.vector = unit.Vector(unit.vector, unit.speed);

            unit.timeShot++;
            if (unit.timeShot > 120)
            {
                listShot.NewShot(unit);
                unit.timeShot = 0;
            }
        }

        //Поиск цели
        private PointF FindTarget(dynamic unit)
        {            
            float findDelta, minDelta = 500;
            foreach (ListUnit party in ListParty)
                foreach (dynamic findUnit in party.listUnits)
                {
                    findDelta = Func2D.Delta(unit.position, findUnit.position);
                    if (findDelta < minDelta)
                    {
                        minDelta = findDelta;
                        unit.target = findUnit.position;
                    }
                }
            return unit.target;
        }
    }
}