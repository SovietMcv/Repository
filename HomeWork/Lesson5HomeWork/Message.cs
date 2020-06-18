using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lesson5HomeWork
{
    
   static class Message
    {
        public static StringBuilder Text { get; set; } = new StringBuilder();
        public static List<string> StringsList { get; set; } = new List<string>();
        public static string LongestWord { get; private set; }
        static int LongestWordLeght { get; set; }

        static Regex regex;        

        public static void GetText(string path)
        {
            Text.Clear();
            StringsList.Clear();
            StreamReader sr = new StreamReader(path);           
            Text.Append(sr.ReadToEnd());
            sr.Close();
            CreateList(path);
        }

        public static void CreateList(string path)
        {
            StreamReader sr = new StreamReader(path);
            string sline = "";
            while (sline != null)
            {             
                sline = sr.ReadLine();
                if (sline == null) break;
                string[] arr = sline.Split(' ');
                foreach (string el in arr)
                {
                    StringsList.Add(el);
                }              
            }
            sr.Close();
            FindLongstWord();
        }

        public static void FindLongstWord()
        {
            LongestWord = "";
            LongestWordLeght = 0;
            foreach (string el in StringsList)
            {
                LongestWord = LongestWord.Count() < el.Length ? el : LongestWord;
                LongestWordLeght = LongestWord.Count() < el.Length ? el.Length : LongestWord.Count();
            }
        }

        public static void DeleteWordThatEndsWithSpecificSymbol(char symbol)
        {
            List<string> slist = new List<string>();

            foreach(string el in StringsList)
            {
                regex = new Regex($"\\b{symbol}");
                if (regex.IsMatch(el)) { slist.Add(el); }
            }
            foreach (string el in slist)
            {
                StringsList.Remove(el);
            }
            Text = BuildTheString();
        }

        public static StringBuilder BuildTheString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(string el in StringsList)
            {
                sb.Append(el + " ");
            }
            return sb;
        }
        public static StringBuilder BuildTheString(int Length)
        {
            StringBuilder sb = new StringBuilder();
            regex = new Regex(@"\b\p{IsCyrillic}{1,"+Length+@"}\b");
            foreach (string el in StringsList)
            {
                _ = regex.IsMatch(el)? sb.Append(el + " ") : sb.Append("");
            }
            return sb;
        }
        public static StringBuilder BuildTheString(List<string> list)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string el in list)
            {
                _ = el.Length == LongestWordLeght ? sb.Append(el + " ") : sb.Append("");
            }
            return sb; 
        }
    }

}