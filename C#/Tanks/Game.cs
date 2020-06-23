using System.Collections.Generic;
using System.Drawing;

namespace Tanks
{
    class Game
    {
        private List<ListUnit> ListParty;
        private ListShot listShot;
        private Action action;

        //Старт игры
        public void StartGame()
        {
            ListParty = new List<ListUnit>();

            ListParty.Add(new ListUnit());
            ListParty.Add(new ListUnit(Color.Red, new Point(20, 20)));
            ListParty.Add(new ListUnit(Color.Blue, new Point(80, 20), 5, 5));
            ListParty.Add(new ListUnit(new Point(80, 80), 5, 5));
            ListParty.Add(new ListUnit(Color.Yellow, new Point(20, 80), 5));
        
            //SW();
            Sound.Music();

            listShot = new ListShot();

            action = new Action();
        }

        //Шаг игры
        public void StepGame(Graphics g)
        {
            action.ActUnit(ListParty, listShot);

            foreach (ListUnit party in ListParty)
                party.DrawListUnit(g, listShot);
                
                listShot.DrawListShot(g);
        }
    }
}