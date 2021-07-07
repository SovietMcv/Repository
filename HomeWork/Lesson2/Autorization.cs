using MethodsLib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

/*
1. Создать программу, которая будет проверять корректность ввода логина. Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
а) без использования регулярных выражений;
б) с использованием регулярных выражений.
 */
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
                Regex regex = new Regex(@"^\D\w[a-zA-Z0-9]{0,11}\b$");
                login = sr.ReadLine();
                password = sr.ReadLine();
                sr.Close();
                Console.WriteLine("Введите логин");
                insLog = Console.ReadLine();
                bool regres = regex.IsMatch(insLog);
                Console.WriteLine("Введите пароль");
                insPass = Console.ReadLine();
                if ((insLog != login || insPass != password) && regres)
                {
                    TryCount++;
                    Console.WriteLine($"Неверный логин или пароль. У вас осталось {MaxtryCount - TryCount} попытки в запасе ");
                }
                else if (!regres)
                {
                    TryCount++;
                    Console.WriteLine($"Длина логина должна быть от 2 до 12 символов, не должен начинаться с цифры и внутри не должно быть пробелов. У вас осталось {MaxtryCount - TryCount} попытки в запасе ");
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
        public static bool CheckLogin(string login)
        {
            
            
            bool GoForward = false;            
            GoForward = (login.Length < 2 || login.Length > 12 || char.IsDigit(login[0])) ? false : true;
            return GoForward;
        }
        public static void AuthorizationWithOutRegEx()
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
                bool gf = CheckLogin(insLog);
                Console.WriteLine("Введите пароль");
                insPass = Console.ReadLine();
                if ((insLog != login || insPass != password) && gf)
                {
                    TryCount++;
                    Console.WriteLine($"Неверный логин или пароль. У вас осталось {MaxtryCount - TryCount} попытки в запасе ");
                }
                else if (!gf)
                {
                    TryCount++;
                    Console.WriteLine($"Длина логина должна быть от 2 до 12 символов, не должен начинаться с цифры и внутри не должно быть пробелов. У вас осталось {MaxtryCount - TryCount} попытки в запасе ");
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