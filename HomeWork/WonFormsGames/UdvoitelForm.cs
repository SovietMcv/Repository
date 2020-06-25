using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WonFormsGames
{
    public partial class UdvoitelForm : Form
    {
        Udvoitel u;
        public UdvoitelForm()
        {
            InitializeComponent();
        }

        private void Start(object sender, EventArgs e)
        {
            u = new Udvoitel();
            RefreshData();
        }

        private void SumButtonClick(object sender, EventArgs e)
        {
            if (u == null) Udvoitel.ShowMessage(1);
            else {u.Plus(); RefreshData(); }

        }
        private void RefreshData()
        {
            TextBox.Text = $"Значение, которого нужно достигнуть: {u.Finish}, Текущее значение: {u.Current}, Правильное количество шагов: {u.Steps}, Текущее количество шагов: {u.Count}";
            if (u.Current == u.Finish)
            {
                Udvoitel.ShowMessage(3);
                TextBox.Text = $"Значение, которого нужно достигнуть: 0, Текущее значение: 0, Правильное количество шагов: 0, Текущее количество шагов: 0";
                u = null;
            }                    
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            if (u == null) Udvoitel.ShowMessage(1);
            else { u.Multi(); RefreshData(); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (u == null) Udvoitel.ShowMessage(1);
            else { u.Back(); RefreshData(); }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (u == null) Udvoitel.ShowMessage(1);
            else { u.Reset(); RefreshData(); }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Udvoitel.ShowMessage(2);
            Close();
        }
    }
}
