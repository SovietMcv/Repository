using MethodsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson2
{
    public partial class HomeWorkTasks
    {
        static int MaxNum = 1000000000;
        static int MinNum = 1;
        static int GoodNumsCount = 0;
        static int CurSum;
        static DateTime startTime;
        static DateTime endTime;
        public static void GoodNums()
        {
            Console.Clear();
            MinNum = 1;
            GoodNumsCount = 0;
            Console.WriteLine($"Давайте попытаемся посчитать количество хороших чисел от 1 до {MaxNum}. Для продолжения нажмите любую клавишу");
            Console.ReadLine();
            startTime = DateTime.Now;
            Console.Clear();
            do
            {
                CurNum = MinNum;
                CurSum = 0;
                foreach (char c in CurNum.ToString())
                {
                    int n = Convert.ToInt32(Convert.ToString(c));
                    CurSum = CurSum + n;                
                }
                if (MinNum % CurSum == 0)
                {
                    GoodNumsCount++;
                }
                MinNum++;
            }
            while (MinNum != MaxNum);
            endTime = DateTime.Now;
            Console.WriteLine($"Количество хороших чисел равно {GoodNumsCount}");
            Console.WriteLine($"Время выполнения равно {endTime - startTime}");
            Console.WriteLine(ReturnText);
            Console.ReadLine();
        }
    }
}