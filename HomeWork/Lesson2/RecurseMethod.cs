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
        static int a;
        static int b;
        static int RecResult = 0;
        static int ChooseMethod;
        static int NumsSum = 0;
        static string WrongText = "Введено некорректное значение";

        static int RecurseSum(int a, int b)
        {
            if (a <= b)
            {
                NumsSum = NumsSum + a;            
                RecurseSum(a+1, b);
            }
            return NumsSum;
        }
        static int RecurseShowNums(int a, int b)
        {
            if (a <= b)
            {
                Console.WriteLine(a);
                RecurseShowNums(a + 1, b);
            }
            return RecResult;
        }
        public static void RecurseChoise()
        {
            Console.Clear();
            RecResult = 0;
            NumCount = 0;
            NumsSum = 0;
            Console.WriteLine("Укажите число a");
            a = Convert.ToInt32(MyMethods.NumsCheck(Console.ReadLine()));
            do
            {
                Console.WriteLine("Укажите число b, оно должно быть больше a");
                b = Convert.ToInt32(MyMethods.NumsCheck(Console.ReadLine()));
                if(a >= b)
                {
                    Console.WriteLine(WrongText);
                }
            }
            while (a >= b);
            Console.WriteLine("Выберите какой метод хотите использовать. Введите 1 для рекурсивной суммы от а до b, включая b. Введите 0 для рекурсивного вывода чисел от a до b на экран");
            do
            {
                ChooseMethod = Convert.ToInt32(MyMethods.NumsCheck(Console.ReadLine()));
                if (ChooseMethod < 0 || ChooseMethod > 1)
                {
                    Console.WriteLine(WrongText);
                }
            }
            while (ChooseMethod < 0 || ChooseMethod > 1);
            if (ChooseMethod == 0)
            {
                Console.WriteLine();
                Console.WriteLine("Отображаем последовательность от a до b");
                RecurseShowNums(a, b);              
            }
            else
            {
                RecurseSum(a, b);
                Console.WriteLine($"Сумма чисел от a до b равна {NumsSum}");
            }
            Console.WriteLine(ReturnText);
            Console.ReadLine();
        }
    }
}