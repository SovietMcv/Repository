using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessGame
{
    public partial class GuessNumForm : Form
    {
        GuessGame guessGame;
        public GuessNumForm()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (guessGame == null) { MessageBox.Show("Игра не начата."); return; }
            guessGame.CheckNum(AnswerText.Text);
            RefreshData();
        }
        private void Start_Click(object sender, EventArgs e)
        {
            guessGame = new GuessGame();
            Start.Enabled = false;
        }
        private void RefreshData()
        {
            if (guessGame.WinParametr == 1)
            {
                history.Text = null;
                ContextText.Text = "Загадано число от 1 до 100.Ваша задача угадать его.Введите значение.";
                guessGame = null;
                Start.Enabled = true;
            }
            else { history.Text = guessGame.history; }       
        }
    }
}
