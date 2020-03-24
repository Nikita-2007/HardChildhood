using System;
using Обучения2;
using целое = System.Int32;
using дробь = System.Double;
using строка = System.String;
using квадраНикитус = System.Console;

namespace Обучение
{

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
        void ВыводНаКонсоль()
        {
            //переменные.Консоль();
            //условия.Консоль2();
            //тд.Структуры();
            целое дурак = 5;
            дробь дебил = 0.777;
            строка x = "shvabra";
            квадраНикитус.WriteLine(дурак + " " + дебил + " "  + x);
        }
    }
}