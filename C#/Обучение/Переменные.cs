using System;

namespace Обучение
{
    class Переменные
    { 
        public void Консоль()
        {
            Console.Write("Сравнение 2>3 - ");
            Console.WriteLine(2>3);
            Console.WriteLine();

            bool y = 2 < 3;
            Console.WriteLine($"Сравнение 2<3 - {y}\n");

            bool x = 2 > 3;
            Console.WriteLine($"Сравнение 2>3 - {x}\n");

            bool z = 2 == 3;
            Console.WriteLine($"Сравнение 2=3 - {z}\n");

            int a = 16;
            Console.WriteLine($"Остаток от деления 16/5 - {a%5}\n");

            Console.WriteLine($"Побитовый сдвиг вниз 16 >> 1 - {a >>= 1}\n");

            Console.WriteLine($"Побитовый сдвиг вниз 16 << 1 - {a <<= 2}\n");

            int b = 100, c = 3;
            decimal d = (decimal) b / c;
            double e = (double)b / c;
            Console.WriteLine(d);
            Console.WriteLine(e);

            Console.WriteLine($"Бинарный код 0b100001 - {0b100001}\n");
            Console.WriteLine($"Байт код 0xA1 - {0xA1}\n");
            Console.WriteLine($"Чисто в степени  3.2e4- {3.2e4}\n");
            Console.WriteLine($"Чисто в степени  1.2e-5 - {1.2e-3}\n");
            Console.WriteLine($"Юни-код u0420 - {"\u0420"}\n");
            Console.WriteLine($"ASKII - {"\x5A"}\n");
        }
    }
}