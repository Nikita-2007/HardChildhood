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
        }
    }
}
