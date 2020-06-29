using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrueFalseNew
{   
    public partial class StartForm : Form
    {

        public StartForm()
        {
            InitializeComponent();
        }

        private void BdStart_Click(object sender, EventArgs e)
        {
            Questions q = new Questions();
            q.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Game_Click(object sender, EventArgs e)
        {
            TrueFalseForm t = new TrueFalseForm();
            t.ShowDialog();
        }
    }
}
