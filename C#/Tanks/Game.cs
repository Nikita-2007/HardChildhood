using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace Tanks
{
    class Game
    {
        private List<ListUnit> ListParty;
        private ListUnit RedParty, BlueParty;
        private ListShot listShot;

        //Старт игры
        public void StartGame()
        {
            ListParty = new List<ListUnit>();

            ListParty.Add(new ListUnit(Color.Red, 20));
            ListParty.Add(new ListUnit(Color.Blue, 80));
            ListParty.Add(new ListUnit(Color.Yellow, 50));

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