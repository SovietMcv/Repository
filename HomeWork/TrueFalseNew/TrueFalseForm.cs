using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrueFalseNew.Models;

namespace TrueFalseNew
{
    public partial class TrueFalseForm : Form
    {

        TrueFalse t = new TrueFalse();
        bool gameend;
        public TrueFalseForm()
        {
            InitializeComponent();

        }
        private void Yes_Click(object sender, EventArgs e)
        {
            gameend = t.CheckAnswer(true);
            UpdateInfo();
            if ( gameend == true)  {MessageBox.Show($"Игра завершена, количество вопросов равно {t.QuestionsCount}, количество правильных ответов равно {t.CorrectAnswerCount}."); this.Close(); } 
        }
        private void No_Click(object sender, EventArgs e)
        {
            gameend = t.CheckAnswer(false);
            UpdateInfo();
            if (gameend == true) { MessageBox.Show($"Игра завершена, количество вопросов равно {t.QuestionsCount}, количество правильных ответов равно {t.CorrectAnswerCount}."); this.Close(); }
        }
        public void UpdateInfo()
        {
            Riddle.Text = t.CurrentDisplayedQuestion;
            CorAnsCount.Text = t.CorrectAnswerCount.ToString();
            QCount.Text = t.QuestionsCount.ToString();
        }

        private void TrueFalseForm_Shown(object sender, EventArgs e)
        {
            t.GetStarted();
            UpdateInfo();
        }
    }
}
