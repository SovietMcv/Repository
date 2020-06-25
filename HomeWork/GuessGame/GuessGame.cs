using System;
using System.Windows.Forms;

/*
Выполнил Федосенко Антон Александрович

2. Используя Windows Forms, разработать игру «Угадай число». Компьютер загадывает число от 1 до 100, а человек пытается его угадать за минимальное число попыток. Для ввода данных от человека используется элемент TextBox.
Старайтесь разбивать программы на подпрограммы. Переписывайте в начало программы условие и свою фамилию. Все программы сделать в одном решении.
 */
namespace GuessGame
{
    class GuessGame
    {
        Random Random;
        int insertedNum;
        int InsertedNum { get { return insertedNum; } 
            set 
            { 
                if (value < 1 || value > 100) 
                {
                    MessageBox.Show("Неверное значение. Диапазон должен быть от 1 до 100"); 
                } 
                else insertedNum = value; } 
            }
        int guessedNum { get; set; }
        public string currentText { get; private set; }
        public string history { get; private set; }
        public int WinParametr { get; private set; } = 0;
        public GuessGame()
        {
            Random = new Random();
            guessedNum = Random.Next(1, 100);
        }
        public void CheckNum(string num)
        {
            try
            {
                InsertedNum = int.Parse(num);
            }
            catch(Exception)
            {
                MessageBox.Show("Неверное значение. Диапазон должен быть от 1 до 100");
                return;
            }
            if (insertedNum == guessedNum)
            {
                MessageBox.Show("Вы угадали");
                WinParametr = 1;
            }
            else if (insertedNum < guessedNum)
            {
                history +=  $"Вы выбрали число {insertedNum}, оно меньше загаданного.\n";

            }
            else if (insertedNum > guessedNum)
            {
                history +=  $"Вы выбрали число {insertedNum}, оно больше загаданного.\n";
            }
        }
    }
}