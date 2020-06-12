using System.Collections.Generic;

namespace Tanks
{
    class Action
    {
        //Перебор всех юнитов
        public void ActUnit(List<ListUnit> ListParty, ListShot listShot)
        {
            foreach (ListUnit party in ListParty)
                foreach (dynamic unit in party.listUnits)
                    if (unit.act != Act.DEAD) Logic(unit);
        }

        //Лагика
        public void Logic(dynamic unit)
        {
            {
                unit.PositionUnit();
                unit.vector = unit.Vector(unit.vector, unit.speed);

                switch (unit.act)
                {
                    case Act.WAIT:
                        break;

                    case Act.FIND:
                        break;

                    case Act.MOVE:
                        break;

                    case Act.FIRE:
                        break;

                    default:
                        unit.Act = Act.WAIT;
                        break;
                }
            }
        }
    }
}