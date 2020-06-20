using System.Collections.Generic;
using System.Drawing;
using Game2d;

namespace Tanks
{
    class Action
    {
        private List<ListUnit> ListParty;
        public PointF _target = PointF.Empty;

        //Перебор всех юнитов
        public void ActUnit(List<ListUnit> ListParty, ListShot listShot)
        {
            this.ListParty = ListParty;

            foreach (ListUnit party in ListParty)
                foreach (dynamic unit in party.listUnits)
                    if (unit.act != Act.DEAD) Logic(unit);
        }

        //Лагика
        public void Logic(dynamic unit)
        {
            {
                switch (unit.act)
                {
                    case Act.WAIT:                        
                        goto case Act.FIRE;
                        //ActWAIT(unit);
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
            unit.target = FindTarget(unit);
        }

        //Процес поиска
        private void ActFIND(dynamic unit)
        {

        }

        //Процес сближения
        private void ActMOVE(dynamic unit)
        {

        }

        //Процес отаки
        private void ActFIRE(dynamic unit)
        {
            unit.PositionUnit();
            unit.vector = unit.Vector(unit.vector, unit.speed);
        }

        //Поиск цели
        private PointF FindTarget(dynamic unit)
        {
            PointF target;
            float temp = 2000;
            float temp2 = 2000;
            foreach (ListUnit party in ListParty)
                foreach (dynamic findUnit in party.listUnits)
                {
                    float find = Func2D.Delta(unit.position, findUnit.position);
                    if (find  < temp || temp < temp2) temp2 = find;
                        temp = find;
                    target = findUnit.position;
                }
            target = _target;
            return target;
        }
    }
}