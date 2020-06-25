//Выполняет Федосенко Антон Александрович
//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) Сделать задание, только вывод организуйте в центре экрана
//в) * Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
//aa
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodsLib;

namespace TextPositioning
{
    class Program
    {
        static string Name;
        static string LastName;
        static string CityName;
        static string text;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя");
            Name = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            LastName = Console.ReadLine();
            Console.WriteLine("Введите название вашего города проживания");
            CityName = Console.ReadLine();
            Console.Clear();
            text = ("Фамилия: " + LastName + " " + "Имя: " + Name + " " + "Город проживания: " + CityName);
            MyMethods.SetTextPosition(text, 30, 15);
            Console.ReadKey();
        }
    }
}
