//Выполняет Федосенко Антон Александрович
//Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах

using MethodsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMT
{
    class Program
    {
        static double mass;
        static double height;
        static double BodyMassIdx; 
        static void Main(string[] args)
        {
            Console.WriteLine("Добрый день! Чтобы вывести индекс массы тела, вам нужно будет по очереди ввести свою массу и свой рост.");
            Console.WriteLine("Укажите свой рост в метрах, пожалуйста.");
            height = MyMethods.NumsCheck(Console.ReadLine());
            Console.WriteLine("Укажите свой вес в кг, пожалуйста.");
            mass = MyMethods.NumsCheck(Console.ReadLine());
            BodyMassIdx = mass / (height * height);
            Console.WriteLine("Ваш индекс равен " + $"{BodyMassIdx:F}");
            Console.ReadKey();
        }
    }
}
