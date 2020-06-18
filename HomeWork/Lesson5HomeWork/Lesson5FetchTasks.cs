using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkLesson2;
using MethodsLib;

namespace Lesson5HomeWork
{
    class Lesson5FetchTasks
    {
        static string[] TaskMap = new string[] { "NumPad1 = Авторизация с проверкой через регулярные выражения", "NumPad2 = Демонстрация собственного класса Message", "Numpad3 = Сравнение строк на перестановку","NumPad4 = Задача ЕГЭ","NumPad5 = Игра Верю - Не верю" ,"Escape = Выйти из программы" };
        static ConsoleKey[] KeyValues = new ConsoleKey[] { ConsoleKey.NumPad1, ConsoleKey.NumPad2, ConsoleKey.NumPad3, ConsoleKey.NumPad4, ConsoleKey.NumPad5, ConsoleKey.Escape };
        static ConsoleKeyInfo key;
        static bool GoForward = false;

        static void FetchTasks(ConsoleKey key)
        {

            switch (key)
            {
                case ConsoleKey.NumPad1:
                    {
                        Console.Clear();
                        do
                        {
                            Console.WriteLine("Укажите какой способ авторизации вы хотите запустить. 1 - С регулярными выражениям, 0 - без регулярных выражений");
                            double k = MyMethods.NumsCheckNoRestr(Console.ReadLine());
                            switch (k)
                            {
                                case 1:
                                    {
                                        HomeWorkTasks.Authorization();
                                        GoForward = true;
                                    }
                                    break;
                                case 0:
                                    {
                                        HomeWorkTasks.AuthorizationWithOutRegEx();
                                        GoForward = true;
                                    }
                                    break;
                            }
                        }
                        while (!GoForward);
                        GoForward = false;                                              
                    }
                    break;
                case ConsoleKey.NumPad2:
                    {
                        Console.Clear();
                        Console.WriteLine("Укажите путь к файлу");
                        string path = Console.ReadLine();
                        Message.GetText(path);
                        Console.WriteLine($"Ваш текст: {Message.Text}");
                        Console.WriteLine();
                        Console.WriteLine($"Одно из самых длинных слов: {Message.LongestWord}");
                        Console.WriteLine();
                        Console.WriteLine("Укажите, что вы хотите сделать с текстом. 1 - Вывести только те слова которые содержат не более N букв. 2 - Удалить те слова, у которых на конце есть символ. 3 - сформировать StringBuilder из всех самых длинных слов ");
                        switch(MyMethods.NumsCheckNoRestr(Console.ReadLine()))
                        {
                            case 1:
                                {
                                    do
                                    {
                                        try
                                        {
                                            Console.WriteLine("Укажите количество букв");
                                            Console.WriteLine($"Текст из слов не больше указанной длины: {Message.BuildTheString(Convert.ToInt32(MyMethods.NumsCheckNoRestr(Console.ReadLine())))}");
                                            GoForward = true;
                                        }
                                        catch
                                        {

                                        }
                                    }
                                    while (!GoForward);
                                }
                                break;
                            case 2:
                                {
                                    do
                                    {
                                        Console.WriteLine("Укажите символ для отбора строк");
                                        try
                                        {
                                            Message.DeleteWordThatEndsWithSpecificSymbol(Convert.ToChar(Console.ReadLine()));
                                            Console.WriteLine($"Получившийся текст: {Message.Text}");                                           
                                            GoForward = true;
                                        }
                                        catch { Console.WriteLine("Введён некорректный символ"); }
                                    }
                                    while (!GoForward);
                                    GoForward = false;        
                                }
                                break;
                            case 3:
                                {
                                    Console.WriteLine($"Вывожу строку слов максимальной длины: {Message.BuildTheString(Message.StringsList)}");
                                    GoForward = true;
                                }
                                break;
                        }
                    }
                    break;
                case ConsoleKey.NumPad3:
                    {
                        Console.Clear();
                        Console.WriteLine("Укажите первое слово");
                        Reallocation.firstline = Console.ReadLine();
                        Console.WriteLine("Укажите второе слово");
                        Reallocation.secondline = Console.ReadLine();
                        if (Reallocation.ReallocationCheckDictionary()) Console.WriteLine("Второе слово является перестановкой первого"); else Console.WriteLine("Второе слово не является перестановкой первого");
                    }
                    break;
                case ConsoleKey.NumPad4:
                    {                       
                        do
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Укажите путь к файлу");
                                UGEtask.ShowBestAndWorstStudents(Console.ReadLine());
                                //Можно было упростить, но я захотел в явном виде их разделить на два списка
                                Console.WriteLine("Лучшие студенты");
                                foreach(var el in UGEtask.BestStudents)
                                { Console.WriteLine($"Фамилия и имя: {el.Key}, средний бал: {el.Value:F}"); }
                                Console.WriteLine("Худшие студенты");
                                foreach (var el in UGEtask.WorstStudents)
                                { Console.WriteLine($"Фамилия и имя: {el.Key}, средний бал: {el.Value:F}"); }
                                GoForward = true;
                            }
                            catch (Exception ex)
                            {
                            Console.WriteLine(ex.Message);
                            }
                        }
                            while (!GoForward);
                        }
                    break;
                case ConsoleKey.NumPad5:
                    {
                        do
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Укажите путь к файлу");
                                BelieveOrNotBelieve.RiddlesProcessing(Console.ReadLine());
                                int points = 0;
                                foreach(var el in BelieveOrNotBelieve.CurrentRiddles)
                                {
                                    Console.WriteLine($"Ваша загадка: {el.Key}");
                                    double answer;
                                    //Немного упростил, чтобы не парсить строку и не приводить её к нужному через ToLower()                                   
                                    do
                                    {
                                        Console.WriteLine("Введите 1 - если Да, 0 - если Нет");
                                        answer = MyMethods.NumsCheckNoRestr(Console.ReadLine());
                                    }
                                    while (answer > 1);
                                    if(answer == el.Value)
                                    {
                                        points++;
                                        Console.WriteLine($"Ответ верный, у вас теперь {points} очк(о,а,ов)");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Ответ неверный");
                                        Console.WriteLine();
                                    }
                                }
                                Console.WriteLine($"Итоговый счёт {points} очк(о,а,ов)");
                                GoForward = true;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        while (!GoForward);
                    }
                    break;
            }
            Console.ReadLine();
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
                        FetchTasks(key.Key);
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
