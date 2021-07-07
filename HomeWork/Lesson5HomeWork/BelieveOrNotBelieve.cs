using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkLesson2;
using MethodsLib;

/*
5. **Написать игру «Верю. Не верю». В файле хранятся вопрос и ответ, правда это или нет. Например: «Шариковую ручку изобрели в древнем Египте», «Да». Компьютер загружает эти данные, случайным образом выбирает 5 вопросов и задаёт их игроку. Игрок отвечает Да или Нет на каждый вопрос и набирает баллы за каждый правильный ответ. Список вопросов ищите во вложении или воспользуйтесь интернетом.
 */

namespace Lesson5HomeWork
{
    class BelieveOrNotBelieve
    {
        public static Dictionary<string, int> RiddlesList { get; private set; } = new Dictionary<string, int>();
        public static Dictionary<string, int> CurrentRiddles { get; private set; } = new Dictionary<string, int>();
        static Random random;
        static int RiddlesCount = 5;
        
        public static void RiddlesProcessing(string path)
        {
            if (RiddlesList != null) RiddlesList.Clear();
            if (CurrentRiddles != null) CurrentRiddles.Clear();
            StreamReader sr = new StreamReader(path);
            random = new Random();
            List<int> UsedIdxs = new List<int>();
            int r;
            string s = "";
            while(s != null)
            {
                s = sr.ReadLine();
                if (s == null) break;
                int c = s[s.Length - 1];
                int value = Convert.ToInt32(char.ConvertFromUtf32(c));
                string newS = s.Remove(s.Length - 1);
                RiddlesList.Add(newS, value);
            }
            for(int i = 0; i < RiddlesCount;i++)
            {
                do { r = random.Next(0, RiddlesList.Count - 1); }
                while (UsedIdxs.Contains(r));
                UsedIdxs.Add(r);
                CurrentRiddles.Add(RiddlesList.ElementAt(r).Key, RiddlesList.ElementAt(r).Value);
            }
        }
    }
}