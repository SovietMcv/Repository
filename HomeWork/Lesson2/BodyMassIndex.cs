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
        static double mass;
        static double height;
        static double BodyMassIdx;
        static double IdxMinNorm = 18.5;
        static double IdxMaxNorm = 25;
        static double NormMass;
        static double MassCorrection;
        public static void BodyMassIndex()
        {
            Console.Clear();
            Console.WriteLine("Чтобы вывести индекс массы тела, вам нужно будет по очереди ввести свою массу и свой рост.");
            Console.WriteLine("Укажите свой рост в метрах, пожалуйста.");
            height = MyMethods.NumsCheck(Console.ReadLine());
            Console.WriteLine("Укажите свой вес в кг, пожалуйста.");
            mass = MyMethods.NumsCheck(Console.ReadLine());
            BodyMassIdx = mass / (height * height);
            Console.WriteLine("Ваш индекс равен " + $"{BodyMassIdx:F}");
            if (BodyMassIdx > IdxMaxNorm)
            {
                NormMass = IdxMaxNorm * height * height;
                MassCorrection = mass - NormMass;
                Console.WriteLine($"Вам нужно похудеть на {MassCorrection:F} кг");
            }
            else if (BodyMassIdx < IdxMinNorm)
            {
                NormMass = IdxMinNorm * height * height;
                MassCorrection =  NormMass - mass;
                Console.WriteLine($"Вам нужно набрать {MassCorrection:F} кг");
            }
            else
            {
                Console.WriteLine("Ваш вес в норме");
            }
            Console.WriteLine(ReturnText);
            Console.ReadKey();
        }
    }
}