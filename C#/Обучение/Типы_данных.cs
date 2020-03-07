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
            Console.WriteLine($"float (7 цифр) {123.456f}\n");
            Console.WriteLine($"double (15-16 цифр) {123.456789d}\n");
            Console.WriteLine($"decimal (28-29 цифр) {123456.789}\n");
            Console.WriteLine($"char (8 бит) {"X"}\n");
            Console.WriteLine($"string (16 бит) {"привет"}\n");
        }
    }
    
}
