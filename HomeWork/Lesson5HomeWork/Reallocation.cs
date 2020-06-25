using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkLesson2;
using MethodsLib;

/*
3. *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой. Регистр можно не учитывать:
а) с использованием методов C#;
б) *разработав собственный алгоритм.
Например:
badc являются перестановкой abcd.
 */

namespace Lesson5HomeWork
{
    static class Reallocation
    {
        public static string firstline { get; set; }
        public static string secondline { get; set; }

        public static bool ReallocationCheckDictionary()
        {
            bool CheckResult = false;
            Dictionary<char, int> dic1 = new Dictionary<char, int>();
            Dictionary<char, int> dic2 = new Dictionary<char, int>();
            char[] fl = firstline.ToCharArray();
            char[] sl = secondline.ToCharArray();
            if (sl.Length == fl.Length)
            {
                int count = 0;
                for (int i = 0; i < fl.Length; i++)
                {
                    if (!dic1.ContainsKey(fl[i])) dic1.Add(fl[i], 1); else dic1[fl[i]]++;
                    if (!dic2.ContainsKey(sl[i])) dic2.Add(sl[i], 1); else dic2[sl[i]]++;
                } 
                foreach (var el in dic1)
                {
                    count = dic2.Contains(el) ? count+1 : count;
                }
                CheckResult = count == dic1.Count() ? true : false;
            }            
            return CheckResult;
        }       
    }
}