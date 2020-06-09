//Выполняет Федосенко Анто Александрович
/*1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;

2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse;
б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки вывести сообщение.Напишите соответствующую функцию;

3. * Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, демонстрирующую все разработанные элементы класса.Достаточно решить 2 задачи.Все программы сделать в одном решении.
** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
 ArgumentException("Знаменатель не может быть равен 0");
Добавить упрощение дробей.*/

using HomeWorkLesson3;
using MethodsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    class HomeWorkTasksFetch
    {
        static string[] TaskMap = new string[] { "NumPad1 = Действия с комплексными числами ", "NumPad2 = Защита от дурака", "Numpad3 = Класс дробей"};
        static ConsoleKey[] KeyValues = new ConsoleKey[] { ConsoleKey.NumPad1, ConsoleKey.NumPad2, ConsoleKey.NumPad3, ConsoleKey.NumPad4, ConsoleKey.Escape };
        static ConsoleKeyInfo key;
        static bool GoForward = false;
        static double choise;
        static void FetchTasks(ConsoleKeyInfo key)
        {
            ConsoleKey KeyValue = key.Key;
            switch(KeyValue)
            {
                case ConsoleKey.NumPad1:
                    {
                        //Делаем проверку внутри проверки, то есть сначала смотрим не строка ли это в собственном методе, 
                        //а потом проверяем внутри свойства диапазон значений от 0 до 100 (не придумал в ночи ничего интересного), эксепшн вываливается из свойства сюда
                        //мы его ловим и ругаемся, что не влез в диапазон
                        //Метод универсальный, поэтому эксепшн остался в свойстве
                        do
                        {
                            try
                            {
                                Console.Clear();
                                ComplexNums nums1 = new ComplexNums();
                                ComplexNums nums2 = new ComplexNums();
                                Console.WriteLine("Укажите мнимое значение первого комплексного числа");
                                nums1.IM = MyMethods.NumsCheck(Console.ReadLine());
                                Console.WriteLine("Укажите вещественное значение первого комплексного числа");
                                nums1.RE = MyMethods.NumsCheck(Console.ReadLine());
                                Console.WriteLine("Укажите мнимое значение второго комплексного числа");
                                nums2.IM = MyMethods.NumsCheck(Console.ReadLine());
                                Console.WriteLine("Укажите вещественное значение второго комплексного числа");
                                nums2.RE = MyMethods.NumsCheck(Console.ReadLine());
                                Console.WriteLine("Укажите, что вы хотите сделать с числами. 1 - сложить их, 2 - вычесть первое из второго, 3 - умножить их друг на друга");
                                choise = MyMethods.NumsCheck(Console.ReadLine());
                                switch (choise)
                                {
                                    case 1:
                                        Console.WriteLine($"Сумма комплексных чисел равна {nums1.ComplexSum(nums1, nums2)}");
                                        break;
                                    case 2:
                                        Console.WriteLine($"Вычитание комплексных чисел равно {nums1.ComplexSubstract(nums2, nums1)}");
                                        break;
                                    case 3:
                                        Console.WriteLine($"Умножение комплексных чисел равно {nums1.ComplexMultipication(nums1, nums2)}");
                                        break;                                  
                                }
                                GoForward = true;
                            }
                            catch (ArgumentOutOfRangeException ex)
                            {
                                Console.WriteLine(ex.ParamName);
                            }
                            Console.ReadLine();
                        }
                        while (GoForward == false);
                        GoForward = false;
                    }
                    break;
                case ConsoleKey.NumPad2:
                    //Реализовал защиту от дурака не через IntTryParse, а через свой метод вместе с обработкой исключений внутри него же
                    //Он уже был у меня реализован на первом уроке было жалко его не использовать, делает он почти тоже самое, но в рекурсии
                    HomeWorkLesson2.HomeWorkTasks.OddNumCount();
                    break;
                case ConsoleKey.NumPad3:
                    do
                    {
                        try
                        {
                            Console.Clear();
                            Fractions fr1 = new Fractions();
                            Fractions fr2 = new Fractions();
                            Console.WriteLine("Укажите числитель первой дроби");
                            fr1.Num = Convert.ToInt32(MyMethods.NumsCheck(Console.ReadLine()));
                            Console.WriteLine("Укажите знаменатель первой дроби");
                            fr1.Denom = Convert.ToInt32(MyMethods.NumsCheck(Console.ReadLine()));
                            Console.WriteLine("Укажите числитель второй дроби");
                            fr2.Num = Convert.ToInt32(MyMethods.NumsCheck(Console.ReadLine()));
                            Console.WriteLine("Укажите знаменатель второй дроби");
                            fr2.Denom = Convert.ToInt32(MyMethods.NumsCheck(Console.ReadLine()));
                            Console.WriteLine("Укажите, что вы хотите сделать с дробями. 1 - сложить их, 2 - вычесть первое из второго, 3 - умножить их друг на друга");
                            choise = MyMethods.NumsCheck(Console.ReadLine());
                            switch (choise)
                            {
                                case 1:
                                    Console.WriteLine($"Сумма дробей равна {Fractions.FractionsSum(fr1,fr2)}");
                                    Console.WriteLine($"Её десятичное представление равно {Fractions.TenthFraction:F}");
                                    Console.WriteLine($"Её упрощённая форма равна {Fractions.Sform}");
                                    break;
                                case 2:
                                    Console.WriteLine($"Вычитание дробей равно {Fractions.FractionsSubstract(fr1,fr2)}");
                                    Console.WriteLine($"Её десятичное представление равно {Fractions.TenthFraction:F}");
                                    Console.WriteLine($"Её упрощённая форма равна {Fractions.Sform}");
                                    break;
                                case 3:
                                    Console.WriteLine($"Умножение дробей равно {Fractions.FractionsMultiplication(fr1,fr2)}");
                                    Console.WriteLine($"Её десятичное представление равно {Fractions.TenthFraction:F}");
                                    Console.WriteLine($"Её упрощённая форма равна {Fractions.Sform}");
                                    break;
                            }
                            GoForward = true;
                        }
                        catch(ArgumentOutOfRangeException ex)
                        {
                            Console.WriteLine(ex.ParamName);
                            Console.ReadLine();
                        }
                    }
                    while (GoForward == false);
                    Console.ReadLine();
                    break;
            }                    
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Добрый день! Давайте выберем задачу для выполнения.Для вывода списка возможных задач нажмите любую клавишу.");
                Console.ReadLine();
                foreach (var x in TaskMap)
                {
                    Console.WriteLine(x);
                }
                Console.WriteLine();
                Console.WriteLine("Чтобы выбрать задачу нажмите указанную клавишу в списке");
                key = Console.ReadKey();
                Console.WriteLine();
                foreach (var n in KeyValues)
                {
                    if (key.Key == n && key.Key != ConsoleKey.Escape)
                    {
                        FetchTasks(key);
                        break;
                    }
                    else if (key.Key == ConsoleKey.Escape)
                    {
                        break;
                    }
                }
            }
            while (key.Key != ConsoleKey.Escape);
            Console.WriteLine("Всего доброго!");
            Console.ReadLine();
        }
    }
}
