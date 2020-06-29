using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrueFalseNew.Models;

namespace TrueFalseNew
{
    
    public partial class Questions : Form
    {      
        QuestionsDataBase questionsData = new QuestionsDataBase();
        public Questions()
        {
            InitializeComponent();          
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите удалить все строки?", "Внимание", MessageBoxButtons.YesNo) == DialogResult.Yes) QuestionsTable.Rows.Clear();
            else return;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            questionsData.SaveDataToDatabase(QuestionsTable.Rows);
            QuestionsTable.Rows.Clear();
            GetData();
        }
        private void GetData()
        {
            questionsData.LoadData();
            for (int x = 0; x < questionsData.ql.Count; x++)
            {
                QuestionsTable.Rows.Add();
            }
            for (int i = 0; i < questionsData.ql.Count; i++)
            {
                QuestionsTable.Rows[i].Cells[0].Value = questionsData.ql[i].Question;
                QuestionsTable.Rows[i].Cells[1].Value = questionsData.ql[i].TrueFalse;
            }
        }

        private void Questions_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Questions_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void AboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("База данных V1.3\n Разработчик: Федосенко Антон Александрович","О программе");
        }
    }
}

