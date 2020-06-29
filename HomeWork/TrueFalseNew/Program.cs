//1. а) Создать приложение, показанное на уроке, добавив в него защиту от возможных ошибок(не создана база данных, обращение к несуществующему вопросу, открытие слишком большого файла и т.д.).
//б) Изменить интерфейс программы, увеличив шрифт, поменяв цвет элементов и добавив другие «косметические» улучшения на свое усмотрение.
//в) Добавить в приложение меню «О программе» с информацией о программе(автор, версия, авторские права и др.).
//г) Добавить в приложение сообщение с предупреждением при попытке удалить вопрос.
//д) Добавить пункт меню Save As, в котором можно выбрать имя для сохранения базы данных(элемент SaveFileDialog).

//2. Используя полученные знания и класс TrueFalse, разработать игру «Верю — не верю».
//3. * Написать программу-преобразователь из CSV в XML-файл с информацией о студентах(6 урок).

//Выполнил Федосенко Антон Александрович

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueFalseNew
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartForm());
        }
    }
}
