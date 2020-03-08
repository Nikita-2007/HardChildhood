using System;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            //Переменые
            string password = "1234", _password = "";

            //Проверка пороля
            while (password != _password) {
                Console.Write("Ведите пороль: ");
                _password = Console.ReadLine();
                if (_password != password) Console.WriteLine("К доступу нет доступа");
             }

            //Доступ
            Console.WriteLine("Доступ разрешили");
            Console.ReadKey();
        }
    }
}