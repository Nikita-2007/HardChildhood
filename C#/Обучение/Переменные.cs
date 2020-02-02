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

            bool x = 2 > 3;
            Console.Write("Сравнение 2>3 - ");
            Console.WriteLine(x);
            Console.WriteLine();

            bool y = 2 < 3;
            Console.Write("Сравнение 2<3 - ");
            Console.WriteLine(y);
            Console.WriteLine();

            bool z = 2 == 3;
            Console.Write("Сравнение 2=3 - ");
            Console.WriteLine(z);
            Console.WriteLine();
        }
    }
}
