using MethodsLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkLesson2
{
    public partial class HomeWorkTasks
    {
        static string login;
        static string password;
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
                //Тут надо указать свой путь, а то было бы странно, если бы мы у пользователя спрашивали путь к файлу с логинами и паролями
                StreamReader sr = new StreamReader("D:\\Files\\LoginPassword.txt");
                login = sr.ReadLine();
                password = sr.ReadLine();
                sr.Close();
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