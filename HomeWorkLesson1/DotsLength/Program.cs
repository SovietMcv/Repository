//Выполняет Федосенко Антон Александрович
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
//б) * Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodsLib;

namespace DotsLength
{
    class Program
    {
        static double x1;
        static double x2;
        static double y1;
        static double y2;
        static double dlength;       
        static double GetDotsLegth (double x1, double y1, double x2, double y2)
        {
            var res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return res;
        }
        static void Main(string[] args)
        {
         
            Console.WriteLine("Добрый день! Сегодня мы попробуем посчитать расстояние между двумя координатами. Для этого вам потребуется последовательно ввести значение x,y для обоих координат");
            Console.WriteLine("Введите значение координаты x1");
            x1 = MyMethods.NumsCheck(Console.ReadLine());
            Console.WriteLine("Введите значение координаты y1");
            y1 = MyMethods.NumsCheck(Console.ReadLine());
            Console.WriteLine("Введите значение координаты x2");
            x2 = MyMethods.NumsCheck(Console.ReadLine());
            Console.WriteLine("Введите значение координаты y2");
            y2 = MyMethods.NumsCheck(Console.ReadLine());
            dlength = GetDotsLegth(x1, y1, x2, y2);
            Console.WriteLine("Расстояние между координатами равно " + $"{dlength:F}");
            Console.ReadKey();
        }
    }
}
