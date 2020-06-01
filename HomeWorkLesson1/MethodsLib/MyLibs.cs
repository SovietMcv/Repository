//Выполняет Федосенко Антон Александрович
//Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsLib
{
    public static class MyMethods
    {
        public static double NumsCheck(string text)
        {
            var res = 0.0;
            if (Double.TryParse(text, out res) == false)
            {
                Console.WriteLine("Некорректное значение, повторите ввод пожалуйста.");
                var newdata = Console.ReadLine();
                res = Convert.ToDouble(NumsCheck(newdata));
            }
            else
            {
                res = Convert.ToDouble(text);
            }
            return res;
        }
        public static void SetTextPosition(string text,int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(text);
            Console.ReadKey();
        }
    }
}
