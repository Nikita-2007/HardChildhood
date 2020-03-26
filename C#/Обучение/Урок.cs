using System;
using Обучения2;
using целое = System.Int32;
using дробь = System.Double;
using строка = System.String;
using квадраНикитус = System.Console;

namespace Обучение
{
    struct Точка
    {
        public int x;
        public int y;
        public string name;
        public void Vivod()
        {
            Console.WriteLine(name + " " + x + " " + y);
        }
    }

    class Урок
    {
        Переменные переменные = new Переменные();
        Условия условия = new Условия();
        Типы_данных тд = new Типы_данных();

        static void Main(string[] args)
        {
            Урок урок = new Урок();
            урок.ВыводНаКонсоль();
            Console.ReadKey();
        }

        unsafe
        void ВыводНаКонсоль()
        {
            //переменные.Консоль();
            //условия.Консоль2();
            //тд.Структуры();
            целое дурак = 5;
            дробь дебил = 0.777;
            строка x = "shvabra";
            квадраНикитус.WriteLine(дурак + " " + дебил + " " + x);

            //Объект структуры
            Точка тчк = new Точка();
            тчк.x = 1_234_567;
            тчк.y = 945_678_910;
            тчк.name = "Никита";
            тчк.Vivod();

            //указатель
            int k = 125;
            int* указатель = &k;
            Console.Write("Регистор памяти " + (long) указатель); 
            
            //Динамический тип данных
            dynamic d = 1;
            Console.WriteLine(d);
            d = "Никита";
            Console.WriteLine(" " + d);

            //Округлеине
            Console.WriteLine(Math.Round(Math.PI, 15));
            Console.WriteLine(Math.Abs(-123));
            Console.WriteLine(Math.Pow(3,99));
            Console.WriteLine(Math.Sqrt(99));
            Console.WriteLine(Math.Min(77, 99));
            Console.WriteLine(Math.Max(77, 99));
            Console.WriteLine(Math.Sin(45));
            Console.WriteLine(Math.Cos(45));
        }
    }
}