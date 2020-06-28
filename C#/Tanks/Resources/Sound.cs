using System;
using System.Threading.Tasks;

namespace Tanks
{
    class Sound
    {

        //Звук выстрела
        async public static void Shot()
        {
            await Task.Run(() => Console.Beep(400, 50));
        }

        //Звук взрыва
        async public static void Bang()
        {
            await Task.Run(() => Console.Beep(100, 100));
        }
        //Звук заставки
        public static void SW()
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
        async public static void Music()
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
