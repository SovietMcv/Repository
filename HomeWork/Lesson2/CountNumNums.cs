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
        static string ReturnText = "Для возврата в главное меню нажмите любую клавишу";
        static int CurNum;
        static int NumCount = 0 ;
        static int[] nums = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        public static void NumNumsCount()
        {
            Console.Clear();
            Console.WriteLine("Сейчас мы попробуем посчитать количество чисел в числе");
            Console.WriteLine("Введите число");
            CurNum = Convert.ToInt32(MyMethods.NumsCheck(Console.ReadLine()));
            foreach (char c in CurNum.ToString())
            {
                string n = Convert.ToString(c);
                foreach (int x in nums)
                {
                    if (Convert.ToInt32(n) == x)
                    {
                        NumCount++;
                        break;
                    }
                }
            }
            Console.WriteLine($"Количество цифр в числе равно {NumCount}");
            Console.WriteLine(ReturnText);
            Console.ReadLine();
        }
    }
}