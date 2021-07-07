using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkLesson2;
using MethodsLib;

/*
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
 */

namespace Lesson5HomeWork
{
    class UGEtask
    {
        static Dictionary<string, double> StudensJournal { get; set; } = new Dictionary<string, double>();
        static List<string> StingList = new List<string>();
        public static Dictionary<string, double> BestStudents { get; private set; } = new Dictionary<string, double>();
        public static Dictionary<string, double> WorstStudents { get; private set; } = new Dictionary<string, double>();
        public static double MaxRating { get; private set; } = 0;
        public static double MinRating { get; private set; } 
        public static void ShowBestAndWorstStudents(string path)
        {
            StreamReader sr = new StreamReader(path);
            if (StingList != null) StingList.Clear();
            if (StudensJournal != null) StudensJournal.Clear();
            if (BestStudents != null) BestStudents.Clear();
            if (WorstStudents != null) WorstStudents.Clear();
            string s = "";
            while (s != null) {s = sr.ReadLine(); if (s == null) break; StingList.Add(s);}
            StingList.RemoveAt(0);
            foreach (string c in StingList)
            {
                string[] arr =  c.Split(' ');
                char res;
                //Сделано так умышленно, потому что предполагается строгий шаблон, но всё на всякий случай вставил проверку и если что в Exception вывалится
                string FI = (!Char.TryParse(arr[0], out res) && !Char.TryParse(arr[1], out res)) ? arr[0] + " " + arr[1] : "";
                double AvarageRating = 0;
                for (int i = 2; i< arr.Length;i++ ) { AvarageRating += Convert.ToDouble(arr[i]);}
                AvarageRating = AvarageRating / (arr.Length - 2);
                StudensJournal.Add(FI, AvarageRating);
            }
            //Ещё не до конца понимаю, как это работает, но очень удобно
            var SortedList = StudensJournal.OrderByDescending(x => x.Value);
            for (int i=0;i<3;i++)
            {
                BestStudents.Add(SortedList.ElementAt(i).Key, SortedList.ElementAt(i).Value);
                WorstStudents.Add(SortedList.ElementAt(SortedList.Count() - i - 1).Key, SortedList.ElementAt(SortedList.Count() - i - 1).Value);
            }
            foreach (var el in SortedList) 
            { 
                for (int i = 0; i < WorstStudents.Count();i++)
                {
                    if(el.Value == WorstStudents.ElementAt(i).Value && el.Key != WorstStudents.ElementAt(i).Key && !WorstStudents.Contains(el))
                    {
                        WorstStudents.Add(el.Key, el.Value);
                    }
                }
            }
        }
    }
}