using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson2
{
    class HomeWorkFetchClass
    {
        static string[] TaskMap = new string[] { "NumPad1 = Поиск минимального числа ", "NumPad2 = Подсчёт количества цифр в числе", "Numpad3 = Подсчитать сумму всех нечетных положительных чисел, вводимых с клавиатуры", "Numpad4 = Попытка авторизации", "Numpad5 = Подсчёт индекса массы тела и что с этим делать", "NumPad6 = Подсчёт хороших чисел и учёт времени выполнения метода", "NumPad7 = Рекурсивный метод (a<b) и сумма от a до b","Escape = Завершить работу программы" };
        static ConsoleKey[] KeyValues = new ConsoleKey[] { ConsoleKey.NumPad1, ConsoleKey.NumPad2, ConsoleKey.NumPad3, ConsoleKey.NumPad4, ConsoleKey.NumPad5, ConsoleKey.NumPad6, ConsoleKey.NumPad7, ConsoleKey.Escape };
        static ConsoleKeyInfo key;
        static void FetchTasks(ConsoleKeyInfo key)
        {
            HomeWorkTasks task = new HomeWorkTasks();
            ConsoleKey KeyValue = key.Key;
            switch(KeyValue)
            {
                case ConsoleKey.NumPad1:
                    HomeWorkTasks.GetMinNum();
                    break;
                case ConsoleKey.NumPad2:
                    HomeWorkTasks.NumNumsCount();
                    break;
                case ConsoleKey.NumPad3:
                    HomeWorkTasks.OddNumCount();
                    break;
                case ConsoleKey.NumPad4:
                    HomeWorkTasks.Authorization();
                    break;
                case ConsoleKey.NumPad5:
                    HomeWorkTasks.BodyMassIndex();
                    break;
                case ConsoleKey.NumPad6:
                    HomeWorkTasks.GoodNums();
                    break;
                case ConsoleKey.NumPad7:
                    HomeWorkTasks.RecurseChoise();
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
