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
        static string login = "root";
        static string password = "GeekBrains";
        static string insPass;
        static string insLog;
        static int TryCount = 0;
        static int MaxtryCount = 3;

        public static void Authorization()
        {
            Console.Clear();
            TryCount = 0;
            Console.WriteLine("Давайте попробуем пройти авторизацию. У вас будет три попытки, после которых вас принудительно отправит в главное меню");
            do
            {
                Console.WriteLine("Введите логин");
                insLog = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                insPass = Console.ReadLine();
                if (insLog != login || insPass != password)
                {
                    TryCount++;
                    Console.WriteLine($"Неверный логин или пароль. У вас осталось {MaxtryCount - TryCount} попытки в запасе ");
                }
            }
            while ((insLog != login || insPass != password) && TryCount != MaxtryCount);
            if (TryCount < MaxtryCount)
            {
                Console.WriteLine("Авторизация прошла успешно");
            }    
            else
            {
                Console.WriteLine("Вы не прошли авторизацию");
            }
            Console.WriteLine(ReturnText);
            Console.ReadLine();
        }
    }
}