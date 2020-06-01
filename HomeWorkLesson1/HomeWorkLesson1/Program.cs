//Выполняет Федосенко Антон Александрович
//Условие: Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
//а) используя склеивание;
//б) используя форматированный вывод;
//в) * используя вывод со знаком $.

using MethodsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace File
{
    class Program
    {
        static string Name;
        static string MiddleName;
        static string LastName;
        static double mass;
        static double age;
        
        static void GetData()
        {
            Console.WriteLine("Укажите ваше имя, пожалуйста.");
            Name = Console.ReadLine();
            Console.WriteLine("Укажате вашу фамилию, пожалуйста.");
            LastName = Console.ReadLine();
            Console.WriteLine("Укажите ваше отчество, пожалуйста.");
            MiddleName = Console.ReadLine();
            Console.WriteLine("Укажите ваш возраст, пожалуйста.");
            age = MyMethods.NumsCheck(Console.ReadLine());
            Console.WriteLine("Укажите ваш вес, пожалуйста.");
            mass = MyMethods.NumsCheck(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день! Я попрошу вас заполнить ваши данные. Нам понадобятся ваша фамилия, имя и отчество");
            GetData();
            Console.WriteLine();
            Console.WriteLine(LastName + " " + Name + " " + MiddleName + ". Ваши данные: вес " + $"{mass:F}" + " кг" + "; Возраст " + age + " лет");
            Console.ReadKey();
        }
    }
}
