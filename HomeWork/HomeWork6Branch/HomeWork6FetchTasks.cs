using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MethodsLib;

//Выполнил Федосенко Антон Александрович

/*
1. Изменить программу вывода функции так, чтобы можно было передавать функции типа double (double,double). Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
б) Используйте массив (или список) делегатов, в котором хранятся различные функции.
в) *Переделайте функцию Load, чтобы она возвращала массив считанных значений. Пусть она
возвращает минимум через параметр.

3. Переделать программу «Пример использования коллекций» для решения следующих задач:
а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (частотный массив);
в) отсортировать список по возрасту студента;
г) *отсортировать список по курсу и возрасту студента;
д) разработать единый метод подсчета количества студентов по различным параметрам
выбора с помощью делегата и методов предикатов.
*Достаточно решить 2 задачи. Старайтесь разбивать программы на подпрограммы. Переписывайте в начало программы условие и свою фамилию.
 */

namespace HomeWork6Branch
{
    public delegate double MyFunc2(double start, double end);
    public delegate int SortFunc<T>(T t1, T t2);
    
    
    public class HomeWork6FetchTasks
    {
        static MyFunc2[] funcs = { XY, XY2, XCOSY,SomeMath };
        static string[] TaskMap = new string[] { "NumPad1 = Демонстрация работы функций с помощью делегатов", "NumPad2 = Демонстрация загрузки из файла и сортировки", "Escape = Выйти из программы" };
        static ConsoleKey[] KeyValues = new ConsoleKey[] { ConsoleKey.NumPad1, ConsoleKey.NumPad2, ConsoleKey.Escape };
        static ConsoleKeyInfo key;
        static bool GoForward = false;
        static List<double> dList = new List<double>();
        static List<double> newList = new List<double>();
        static List<Students> slist = new List<Students>();
        static double res;
        static int choise;
        
        public static void Table (MyFunc2 F, double start, double end, double step)
        {
            while (start <= end)
            {
                Console.WriteLine($"|{start:0.000} | {F.Invoke(start, end):0.000} |");
                start += step;
            }
            Console.WriteLine("---------------------");
        }      
        public static double XY(double x,double y)
        {
            return x * y;
        }
        public static double XY2(double x,double y)
        {
            return x * y * y;
        }
        public static double XCOSY(double x, double y)
        {
            return x * Math.Cos(y);
        }
        public static double SomeMath(double x, double y)
        {
            return y * x - 50 * Math.Cos(y) + 10*x;
        }
        //Я ещё плохо понимаю когда именно нужно и стоит использовать делегаты, но тут переделал так, чтобы любой из существующих методов подходящей сигнатуры можно было передать
        public static void SaveToBinaryFile(string fileName,MyFunc2 F ,double start, double end, double step)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = start;
            double y = end;
            while (x <= y)
            {
                bw.Write(F.Invoke(x,y));
                x += step;
            }
            bw.Close();
            fs.Close();
        }
        public static List<double> Load(string fileName, out double min)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            min = double.MaxValue;
            for (int i =0; i< fs.Length/sizeof(double);i++)
            {
                double lastnum = bw.ReadDouble();
                min = min > lastnum ? lastnum : min;
            }
            bw.Close();
            fs.Close();
            return dList;
        }
        static int SortProcessing(int SortType, SortFunc<int> F,SortFunc<string> F1,Students s1,Students s2)
        {
            if (SortType == 1)
            {
                return F.Invoke(s1.Age, s2.Age);
            }
            else if (SortType == 2)
            {
                return F.Invoke(s1.stage, s2.stage);
            }
            else if (SortType == 3)
            {
                int ageres = F.Invoke(s1.Age, s2.Age);
                int stageres = F.Invoke(s1.Age, s2.Age);
                if ((stageres == 1 && ageres == 1) || (stageres == 1 && ageres == -1)) return 1;
                else if ((stageres == -1 && ageres == 1) || (stageres == -1 && ageres == -1)) return -1;
                else return 0;
            }
            else if (SortType == 4)
            {
                return F1.Invoke(s1.FamilyName, s2.FamilyName);
            }
            else if (SortType == 5)
            {
                return F1.Invoke(s1.City, s2.City);
            }
            else return 0;


        }
        static int IntCompare(int nums1,int nums2)
        {
            if (nums1 > nums2) return 1;
            else if (nums1 < nums2) return -1;
            else return 0;
        }
        static int StringCompare(string line1,string line2)
        {
            if (line1[0] > line2[0]) return 1;
            else if (line1[0] < line2[0]) return -1;
            else return 0;
        }
        //Просто не успевал сделать пункт Д, поэтому оставил без него/ Update - переделал, не очень красиво, но сходу не нашёл как сделать повеселее. Ещё подумаю.
        static int Comparator(Students s1, Students s2)
        {
            return SortProcessing(choise, IntCompare, StringCompare, s1, s2);
        }       
        
        static void FetchTasks(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.NumPad1:
                    {
                        do
                        {
                            Console.Clear();
                            if (dList != null || newList != null) { dList.Clear(); newList.Clear(); }
                            Console.WriteLine("Попробуем вывести значения функций в виде таблицы с заданным шагом");
                            Console.WriteLine("Укажите первое значение");
                            double start = MyMethods.NumsCheckNoRestr(Console.ReadLine());
                            Console.WriteLine("Укажите второе значение");
                            double end = MyMethods.NumsCheckNoRestr(Console.ReadLine());
                            Console.WriteLine("Укажите шаг");
                            double step = MyMethods.NumsCheckNoRestr(Console.ReadLine());
                            Console.WriteLine("Укажите какую функцию хотите вывести. 1 - x*y; 2 - x*y^2;3 - x*cos(y),4-придуманная функция y * x - 50 * Math.Cos(y) + 10*x");
                            double x = MyMethods.NumsCheckNoRestr(Console.ReadLine());
                            switch (x)
                            {
                                case 1:
                                    {
                                        Table(funcs[0], start, end, step);
                                        SaveToBinaryFile("Suslik.bin", funcs[0], start, end, step);
                                        GoForward = true;
                                    }
                                    break;
                                case 2:
                                    {
                                        Table(funcs[1], start, end, step);
                                        SaveToBinaryFile("Suslik.bin", funcs[1], start, end, step);                                       
                                        GoForward = true;
                                    }
                                    break;
                                case 3:
                                    {
                                        Table(funcs[2], start, end, step);
                                        SaveToBinaryFile("Suslik.bin", funcs[2], start, end, step);
                                        GoForward = true;
                                    }
                                    break;
                                case 4:
                                    {
                                        Table(funcs[3], start, end, step);
                                        SaveToBinaryFile("Suslik.bin", funcs[3], start, end, step);
                                        GoForward = true;
                                    }
                                    break;
                            }
                        }
                        while (GoForward == false);
                        newList = Load("Suslik.bin", out res);
                        foreach (var el in newList)
                        {
                            Console.WriteLine($"{el:F}");
                        }
                        Console.WriteLine($"Минимальное значиние функции равно {res:F}");
                        GoForward = false;
                        Console.ReadLine();
                    }
                    break;
                case ConsoleKey.NumPad2:
                    {
                        Console.Clear();
                        Console.WriteLine("Укажите путь к файлу");
                        string path = Console.ReadLine();
                        StreamReader sr = new StreamReader(path);
                        if (slist != null) slist.Clear();
                        string s = "";
                        while(s != null)
                        {
                            s = sr.ReadLine();
                            if (s == null) break;
                            string[] arr = s.Split(';');
                            slist.Add(new Students() { FamilyName = arr[0], Name = arr[1], Univercity = arr[2], Faculty = arr[3], Department = arr[4], Age = Convert.ToInt32(arr[5]), stage = Convert.ToInt32(arr[6]), City = arr[7] });
                        }
                        sr.Close();
                        Console.WriteLine("Укажите способ сортировки 1 - по возрасту, 2 - по курсу, 3- по курсе и возрасту, 4 - по фамилии, 5 - по городу ");
                        choise = Convert.ToInt32(MyMethods.NumsCheckNoRestr(Console.ReadLine()));
                        slist.Sort(Comparator);
                        foreach (var el in slist)
                        {
                            Console.WriteLine($"Фамилия: {el.FamilyName}, Имя: {el.Name}, Университет: {el.Univercity}, Факультет: {el.Faculty}, Возраст: {el.Age}, Курс: {el.stage}");
                        }
                        ConvertToXml("Students.xml", slist);
                        Console.ReadLine();
                    }
                    break;
            }
        }

        public static void ConvertToXml(string filename, List<Students> list)
        {
            XmlSerializer sr = new XmlSerializer(typeof(List<Students>));
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            sr.Serialize(fs, list);
            fs.Close();
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
