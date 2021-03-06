﻿using System.Collections.Generic;
using System.Drawing;

namespace Tanks
{
    class Game
    {
        private List<ListUnit> ListParty;
        private ListShot listShot;
        private Action action;
        private Shooting shooting;
        private Unit unit;

        //Старт игры
        public void StartGame()
        {
            ListParty = new List<ListUnit>();

            ListParty.Add(new ListUnit(Color.Red, new Point(20, 20)));
            ListParty.Add(new ListUnit(Color.Blue, new Point(80, 80), 5, 5));
            //ListParty.Add(new ListUnit());
            //ListParty.Add(new ListUnit(new Point(80, 80), 5, 5));
            //ListParty.Add(new ListUnit(Color.Yellow, new Point(20, 80), 5));

            //SW();
            Sound.Music();            

            listShot = new ListShot();

            action = new Action();
            shooting = new Shooting();          
        }

        //Шаг игры
        public void StepGame(Graphics g)
        {
            action.ActUnit(ListParty, listShot);
            shooting.ActShot(ListParty, listShot);

            listShot.DrawListCratar(g);
            foreach (ListUnit party in ListParty)
                party.DrawListUnit(g);                
            listShot.DrawListShot(g);
        }
    }
}