using System.Collections.Generic;

namespace Tanks
{
    class Action
    {
        private List<ListUnit> ListParty;

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
            if (unit.life <= 0)
                unit.act = Act.DEAD;
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
    }
}