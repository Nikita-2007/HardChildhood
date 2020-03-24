using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Обучение
{
    class Типы_данных
    {
        public void данные()
        {
            Console.WriteLine($"bool (8 бит) {true}\n");
            Console.WriteLine($"sbyte (8 бит) {-123}\n");
            Console.WriteLine($"byte (8 бит) {250}\n");
            Console.WriteLine($"short (16 бит) {-32000}\n");
            Console.WriteLine($"ushort (16 бит) {600005}\n");
            Console.WriteLine($"int (32 бит) {-123456789}\n");
            Console.WriteLine($"uint (32 бит) {9876543210}\n");
            Console.WriteLine($"long (64 бит) {-64000000000}\n");
            Console.WriteLine($"ulong (64 бит) {128000000000}\n");
            Console.WriteLine($"float (32 бит) {123.456f}\n");
            Console.WriteLine($"double (64 бит) {123.456789d}\n");
            Console.WriteLine($"decimal (128 бит) {123456.789}\n");
            Console.WriteLine($"char (16 бит) {"X"}\n");
            Console.WriteLine($"string (Сылка) {"привет"}\n");
        }

        public enum Неделя {Понедельник, Вторник, Среда, Четверг ,Пятница, Суббота, Воскресенье}
        public void Структуры()
        {
            Неделя день = 0;
            for (byte i = 0; i < 7;  i++)
                Console.WriteLine($" День недели {день + i}\n");
            var toble = (5, 10,25 ,67,777,890,240234226436,120461);

            Console.WriteLine($"{toble}\n");

            (string, int, double) школьник = ("Егор", 2007, 8.113);
            Console.WriteLine($"{школьник}\n");
            Console.WriteLine($"{школьник.Item2}\n");
        }
    }
    
}
