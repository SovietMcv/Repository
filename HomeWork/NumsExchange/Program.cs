//Написать программу обмена значениями двух переменных.
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumsExchange
{
    class Program
    {
        static string x;
        static string y;
        static string t;

        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите переменную x");
            x = Console.ReadLine();
            Console.WriteLine("Введите переменную y");
            y = Console.ReadLine();
            t = x;
            x = y;
            y = t;
            Console.WriteLine("x = " + x + ", "+ "y = " + y);
            Console.ReadKey();
        }
    }
}
