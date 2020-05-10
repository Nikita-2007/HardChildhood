using System;
using System.Drawing;
using System.Threading.Tasks;

namespace Tanks
{
    class Game
    {
        private ListUnit RedParty, BlueParty;
        private ListShot AlistShot;
        Shot shot;

        //Старт игры
        public void StartGame()
        {

            //Красные
            RedParty = new ListUnit();
            RedParty.CreateListUnits(Color.Red, 20);

            //Сниние
            BlueParty = new ListUnit();
            BlueParty.CreateListUnits(Color.Blue, 80);

            //SW();
            Sound();

            shot = new Shot();
            shot.position = new PointF(50, 50);
            shot.target = new PointF(1000, 600);
            shot.speed = 20;
        }

        //Шаг игры
        public void StepGame(Graphics g, Point cursor)
        {
            RedParty.DrawListUnit(g, cursor);
            BlueParty.DrawListUnit(g, cursor);
            shot.DrawShot(g);
            //shot.DrawListShot(g);
        }

        //Звук заставки
        private void SW()
        {
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(659, 500);
            Console.Beep(698, 350);
            Console.Beep(523, 150);
            Console.Beep(415, 500);
            Console.Beep(349, 350);
            Console.Beep(523, 150);
            Console.Beep(440, 1000);
        }
        async private void Sound()
        {
            await Task.Run(() =>
            {
                Console.Beep(440, 500);
                Console.Beep(500, 500);
                Console.Beep(440, 500);
                Console.Beep(300, 500);
                Console.Beep(37, 1);
                Console.Beep(275, 200);
                Console.Beep(250, 200);
                Console.Beep(225, 200);
                Console.Beep(200, 200);
                Console.Beep(150, 750);
            });
        }
    }
}