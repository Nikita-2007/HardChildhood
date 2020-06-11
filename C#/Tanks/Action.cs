using System.Collections.Generic;
using System.Drawing;

namespace Tanks
{
    class Action
    {
        public void ActUnit(List<ListUnit> ListParty, ListShot listShot)
        {
            foreach (ListUnit party in ListParty)
                foreach (dynamic unit in party.listUnits)
                {
                    unit.PositionUnit();
                    unit.vector = unit.Vector(unit.vector, unit.speed);
                }    
        }
    }
}
