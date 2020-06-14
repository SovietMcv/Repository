using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodsLib;
using HomeWorkLesson2;

namespace Lesson4MainBranch
{
    class Lesson4TasksFetch
    {
        static string[] TaskMap = new string[] { "NumPad1 = Операции с массивами", "NumPad2 = Авторизация со считыванием из файла логина и пароля", "Numpad3 = Операции с двумерными массивами" };
        static ConsoleKey[] KeyValues = new ConsoleKey[] { ConsoleKey.NumPad1, ConsoleKey.NumPad2, ConsoleKey.NumPad3, ConsoleKey.NumPad4, ConsoleKey.Escape };
        static ConsoleKeyInfo key;
        static bool GoForward = false;

        static void FetchTasks(ConsoleKeyInfo key)
        {
            ConsoleKey KeyValue = key.Key;
            switch (KeyValue)
            {
                case ConsoleKey.NumPad1:
                    {
                        string[] ArrTasks = new string[] { "1 = Получить сумму элементов первого массива", "2 = Изменить знак у каждого элемента первого массива", "3 = Умножить каждый элемент массива на определённое значение","4 - Получить количество максимальных элементов первого массива","5 - Получить длину первого массива", "6 - объединить массивы","7 - Изменить длину массива", "8 - Вывести количество пар элементов массива, которые делятся на три","9 - вывести ссылку на каждый элемент массива","10 - Вывести копию массива","11 - Считать набор чисел из файла и вывести их массив на экран","12 - Записать значения первого массива в файл","13 - выйти в главное меню" };
                        Console.Clear();
                        Console.WriteLine("Верхнюю границу первого массива");
                        int max = Convert.ToInt32(MyMethods.NumsCheckNoRestr(Console.ReadLine()));
                        Console.WriteLine("Нижнюю границу первого массива");
                        int min = Convert.ToInt32(MyMethods.NumsCheckNoRestr(Console.ReadLine()));
                        MyArray arr1 = new MyArray(min, max);
                        Console.WriteLine("Верхнюю границу второго массива");
                        int max1 = Convert.ToInt32(MyMethods.NumsCheckNoRestr(Console.ReadLine()));
                        Console.WriteLine("Нижнюю границу второго массива");
                        int min1 = Convert.ToInt32(MyMethods.NumsCheckNoRestr(Console.ReadLine()));
                        MyArray arr2 = new MyArray(min1, max1);
                        Console.WriteLine("Значения первого массива");
                        arr1.ShowArrayElements();
                        Console.WriteLine("Значения второго массива");
                        arr2.ShowArrayElements();
                        do
                        {
                            Console.WriteLine("Что вы хотите сделать с данными массивами?");
                            foreach (string s in ArrTasks)
                            {
                                Console.WriteLine(s);
                            }
                            Console.WriteLine();
                            double value = MyMethods.NumsCheck(Console.ReadLine());
                            switch (value)
                            {
                                case 1:
                                    {
                                        Console.WriteLine(arr1.ArrayElementsSum());
                                        Console.WriteLine();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 2:
                                    {
                                        arr1.ArrayElementsInverse();
                                        arr1.ShowArrayElements();
                                    }
                                    break;
                                case 3:
                                    {
                                        Console.WriteLine("Укажите на какое значение нужно умножить.");
                                        int multnum = Convert.ToInt32(MyMethods.NumsCheckNoRestr(Console.ReadLine()));
                                        arr1.ArrayElementsMultByNum(multnum);
                                        Console.WriteLine("Получившиеся значения");
                                        arr1.ShowArrayElements();
                                        Console.WriteLine();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 4:
                                    {
                                        Console.WriteLine($"Количество максимальных значений первого массива равно {arr1.ArrayElementsMaxCount()}");
                                        Console.WriteLine();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 5:
                                    {
                                        Console.WriteLine($"Длина первого массива равна {arr1.Length}");
                                        Console.WriteLine();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 6:
                                    {
                                        Console.WriteLine("Вывожу значения объединённого массива");
                                        MyArray.ShowArrayElements(MyArray.ArrayMerge(arr1, arr2));
                                        Console.WriteLine();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 7:
                                    {
                                        Console.WriteLine("Укажите длину массива");
                                        int length = Convert.ToInt32(MyMethods.NumsCheckNoRestr(Console.ReadLine()));
                                        arr1.ArrayResize(length);
                                        Console.WriteLine($"Длина массива равна {arr1.Length}");
                                        Console.WriteLine("Вывожу элементы массива");
                                        arr1.ShowArrayElements();
                                        Console.WriteLine();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 8:
                                    {
                                        Console.WriteLine($"Количество пар элементов первого массива, которые делятся на 3 равно: {arr1.ArrayDivNumsCount()}");
                                        Console.WriteLine();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 9:
                                    {
                                        Console.WriteLine("Выводим ссылку на каждый элемент первого массива");
                                        for(int c = 0; c < arr1.Arr.Length; c++)
                                        {
                                            Console.Write($"{arr1.Arr[c]}" + " ");
                                        }
                                        Console.WriteLine();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 10:
                                    {
                                        Console.WriteLine("Выводим копию первого массива");
                                        MyArray.ShowArrayElements(arr1.ArrayCopy());
                                        Console.WriteLine();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 11:
                                    {
                                        Console.WriteLine("Укажите путь к файлу");
                                        string path = Console.ReadLine();
                                        MyArray arr = new MyArray(path);
                                        arr.ShowArrayElements();
                                        Console.WriteLine();
                                        Console.ReadLine();
                                    }
                                    break;
                                case 12:
                                    {
                                        Console.WriteLine("Укажите путь к файлу");
                                        string path = Console.ReadLine();
                                        arr1.WriteArrayToFile(path);
                                        Console.WriteLine("Значения записаны в файл");
                                        Console.ReadLine();
                                    }
                                    break;
                                case 13:
                                    {
                                        GoForward = true;                                       
                                    }
                                    break;
                            }
                        }
                        while (GoForward == false);
                        GoForward = false;
                        Console.WriteLine("Для возвращения в главное меню нажмите любую клавишу");
                        Console.ReadLine();
                    }
                    break;
                case ConsoleKey.NumPad2:
                    {
                        //В методе надо указать свой путь к файлику, а то было бы странно, если бы мы у пользователя спрашивали путь к файлу с логинами и паролями, там правда экспешены не обрабатываются
                        HomeWorkTasks.Authorization();
                    }
                    break;
                case ConsoleKey.NumPad3:
                    {
                        TwoDimensionsArray tw = new TwoDimensionsArray(2, -100, 100);
                        Console.WriteLine("Вывод всех элементов массива");
                        foreach(int c in tw.Arr)
                        {
                            Console.Write(c + " ");
                        }
                        Console.WriteLine();
                        tw.MaxElementIdx(out int i, out int j);
                        Console.WriteLine($"Номер максимального элемента равен [{i},{j}]");
                        Console.WriteLine($"Сумма всем элементов массива равно = {tw.ElementsSum()}");
                        Console.WriteLine($"Сумма всех элементов массива больше заданного числа(на примере 0) равна {tw.ElementsSumAboveZero()}");
                        do 
                        {
                            //Вариант ловли эксепшенов внутри
                            Console.WriteLine($"Попытка считать и вывести данные из файла в двумерный массив. Укажите путь к файлу");
                            string path = Console.ReadLine();
                            TwoDimensionsArray tw2 = new TwoDimensionsArray(path);
                            if (tw2.Arr == null)
                            {

                            }
                            else
                            {
                                foreach (int c in tw2.Arr)
                                {
                                    Console.Write(c + " ");
                                }
                                Console.WriteLine();
                                GoForward = true;
                            }                       
                        }
                        while (GoForward == false);
                        GoForward = false;
                        //Вариант ловли эксепшенов снаружи
                        do 
                        {
                            try
                            {
                                Console.WriteLine($"Попытка записать в файл значения первого массива.Укажите путь к файлу");
                                string path = Console.ReadLine();
                                tw.WriteToFile(path);
                                GoForward = true;
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        while (GoForward == false);
                        GoForward = false;
                        Console.ReadLine();
                    }
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
