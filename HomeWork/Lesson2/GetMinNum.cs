using MethodsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson2
{
    public partial class HomeWorkTasks
    {
        static double result;
        static double x;
        static double y;
        static double z;
        static double min;
        public static void GetMinNum()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Добрый день! Мы с вами попробуем найти минимальное из трёх чисел");
            Console.WriteLine("Введите первое число");
            x = MyMethods.NumsCheck(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            y = MyMethods.NumsCheck(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            z = MyMethods.NumsCheck(Console.ReadLine());
            min = x > y ? y : x;
            min = z < min ? z : min;
            Console.WriteLine($"Минимально число равно {min}");
            Console.WriteLine(ReturnText);
            Console.ReadLine();
        }
    }
}