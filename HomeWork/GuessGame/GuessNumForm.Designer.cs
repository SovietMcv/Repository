namespace GuessGame
{
    partial class GuessNumForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.history = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Start = new System.Windows.Forms.Button();
            this.ContextText = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.AnswerText = new System.Windows.Forms.RichTextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.history);
            this.groupBox2.Location = new System.Drawing.Point(12, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(470, 165);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "История";
            // 
            // history
            // 
            this.history.Location = new System.Drawing.Point(10, 20);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(454, 139);
            this.history.TabIndex = 0;
            this.history.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Start);
            this.groupBox1.Controls.Add(this.ContextText);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.AnswerText);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 148);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Панель ввода";
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(388, 97);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(75, 23);
            this.Start.TabIndex = 3;
            this.Start.Text = "Начать";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // ContextText
            // 
            this.ContextText.AutoSize = true;
            this.ContextText.Location = new System.Drawing.Point(7, 38);
            this.ContextText.Name = "ContextText";
            this.ContextText.Size = new System.Drawing.Size(380, 13);
            this.ContextText.TabIndex = 2;
            this.ContextText.Text = "Загадано число от 1 до 100. Ваша задача угадать его. Введите значение.";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(6, 98);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 1;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AnswerText
            // 
            this.AnswerText.Location = new System.Drawing.Point(6, 65);
            this.AnswerText.Name = "AnswerText";
            this.AnswerText.Size = new System.Drawing.Size(116, 27);
            this.AnswerText.TabIndex = 0;
            this.AnswerText.Text = "";
            // 
            // GuessNumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GuessNumForm";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox history;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label ContextText;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.RichTextBox AnswerText;
    }
}

