using System;
using System.Collections.Generic;
using System.Windows.Forms;
/*
1. а) Добавить в программу «Удвоитель» подсчет количества отданных команд.
б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок. Игрок должен постараться получить это число за минимальное количество ходов.
в) * Добавить кнопку «Отменить», которая отменяет последние ходы.
 */
namespace WonFormsGames
{
    class Udvoitel
    {
        int current = 1;
        int count = 0;
        public int Finish { get; private set; }
        public Stack<int> history = new Stack<int>();


        public int Current
        {
            get { return current; }
        }


        public int Count
        {
            get { return count; }
        }
        public int Steps
        {
            get
            {
                int f = Finish;
                int i = 0;
                while (f != 1)
                {
                    f = f % 2 == 0 ? f / 2 : f - 1;
                    i++;
                }
                return i;
            }
        }

        public Udvoitel(int min, int max)
        {
            Finish = new Random().Next(min, max + 1);
        }

        public Udvoitel()
        {
            Finish = new Random().Next(10, 101);
        }

        public Udvoitel(int finish)
        {
            this.Finish = finish;
        }


        public int Plus()
        {
            count++;
            history.Push(current);
            current++;
            return current;
        }

        public int Multi()
        {
            count++;
            history.Push(current);
            current *= 2;
            return current;
        }

        public void Reset()
        {
            current = 1;
            history.Clear();
            count = 0;
        }

        public void Back()
        {
            if (history.Count != 0)
            {
                count -= 1;
                current = history.Pop(); 
            }
        }

        public override string ToString()
        {
            return current.ToString();
        }

        public static void ShowMessage(int x)
        {
            if (x == 1) MessageBox.Show("Игра ещё не начата");
            else if (x == 2) MessageBox.Show("Всего доброго!");
            else if (x == 3) MessageBox.Show("Вы победили!");
        }
    }
}