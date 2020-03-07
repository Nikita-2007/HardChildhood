using System;

namespace Обучения2
{
    class Условия
    {
        public void Консоль2()
        {
            bool a = true & true;  //и
            bool b = false ^ true; //либо
            bool x = a | b;        //или
            if (x)
            {
                Console.WriteLine("Условие верно ");
            }
            else
            {
                Console.WriteLine("Условие неверно ");
            }

            Console.WriteLine($"Сравнение + и + {true & true}\n");
            Console.WriteLine($"Сравнение + и - {true & false}\n");
            Console.WriteLine($"Сравнение - и - {false & false}\n");

            Console.WriteLine($"Сравнение + лмбо + {true ^ true}\n");
            Console.WriteLine($"Сравнение + либо - {true ^ false}\n");
            Console.WriteLine($"Сравнение - либо - {false ^ false}\n");

            Console.WriteLine($"Сравнение + или + {true | true}\n");
            Console.WriteLine($"Сравнение + или - {true | false}\n");
            Console.WriteLine($"Сравнение - или - {false| false}\n");

            int i = 2147400000;
            bool y= true;
            do
            {
               y = i < 10;
                Console.WriteLine(i++);
            }
            while (y);
        }
    }
}