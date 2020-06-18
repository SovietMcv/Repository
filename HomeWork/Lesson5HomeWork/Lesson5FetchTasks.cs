using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkLesson2;
using MethodsLib;

/*
1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) с использованием регулярных выражений.

2. Разработать класс Message, содержащий следующие статические методы для обработки
текста:
а) Вывести только те слова сообщения, которые содержат не более n букв.
б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
в) Найти самое длинное слово сообщения.
г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
Продемонстрируйте работу программы на текстовом файле с вашей программой.

3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
а) с использованием методов C#;
б) *разработав собственный алгоритм.
Например:
badc являются перестановкой abcd.

4. Задача ЕГЭ.
*На вход программе подаются сведения о сдаче экзаменов учениками 9-х классов некоторой средней
школы. В первой строке сообщается количество учеников N, которое не меньше 10, но не
превосходит 100, каждая из следующих N строк имеет следующий формат:
<Фамилия> <Имя> <оценки>,
где <Фамилия> — строка, состоящая не более чем из 20 символов, <Имя> — строка, состоящая не
более чем из 15 символов, <оценки> — через пробел три целых числа, соответствующие оценкам по
пятибалльной системе. <Фамилия> и <Имя>, а также <Имя> и <оценки> разделены одним пробелом.
Пример входной строки:
Иванов Петр 4 5 3
Требуется написать как можно более эффективную программу, которая будет выводить на экран
фамилии и имена трёх худших по среднему баллу учеников. Если среди остальных есть ученики,
набравшие тот же средний балл, что и один из трёх худших, следует вывести и их фамилии и имена.
Достаточно решить 2 задачи. Старайтесь разбивать программы на подпрограммы. Переписывайте в
начало программы условие и свою фамилию. Все программы сделать в одном решении. Для решения
задач используйте неизменяемые строки (string)

5. **Написать игру «Верю. Не верю». В файле хранятся вопрос и ответ, правда это или нет. Например: «Шариковую ручку изобрели в древнем Египте», «Да». Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задаёт их игроку. Игрок отвечает Да или Нет на каждый вопрос и набирает баллы за каждый правильный ответ. Список вопросов ищите во вложении или воспользуйтесь интернетом.
 */

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
