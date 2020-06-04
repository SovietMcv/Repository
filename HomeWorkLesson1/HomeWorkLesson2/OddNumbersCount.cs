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
        static int InsNum;
        static int OddnumberSum = 0;
        public static void OddNumCount()
        {         
            Console.Clear();
            Console.WriteLine("Давайте попробуем посчитать сумму введённых нечётных чисел.Ввод чисел не будет остановлен, пока не будет введено значение 0. Для начала нажмите любую клавишу");
            Console.ReadLine();
            do
            {
                Console.WriteLine("Введите число");
                InsNum = Convert.ToInt32(MyMethods.NumsCheck(Console.ReadLine()));
                if(InsNum % 2 != 0)
                {
                    OddnumberSum = OddnumberSum + InsNum;
                }
            }
            while (InsNum != 0);
            Console.WriteLine($"Сумма нечётных введённых нечётных чисел равна {OddnumberSum}");
            Console.WriteLine(ReturnText);
            Console.ReadLine();
        }
    }
}