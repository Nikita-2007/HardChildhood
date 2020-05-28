using System.Collections.Generic;
using System.Drawing;

namespace Tanks
{
    class Game
    {
        private List<ListUnit> ListParty;
        private ListShot listShot;

        //Старт игры
        public void StartGame()
        {
            ListParty = new List<ListUnit>();

            ListParty.Add(new ListUnit(Color.Red, new Point(10,10)));
            ListParty.Add(new ListUnit(Color.Blue, new Point (80, 80)));
            ListParty.Add(new ListUnit());
            ListParty.Add(new ListUnit(new Point (10, 80), 5, 5));

            //SW();
            Sound.Music();

            listShot = new ListShot();
        }

        //Шаг игры
        public void StepGame(Graphics g, Point cursor)
        {
            foreach (ListUnit party in ListParty)
                party.DrawListUnit(g , cursor, listShot);

                listShot.DrawListShot(g);
        }
    }
}