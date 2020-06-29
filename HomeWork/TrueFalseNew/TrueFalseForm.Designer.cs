namespace TrueFalseNew
{
    partial class TrueFalseForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.No = new System.Windows.Forms.Button();
            this.Yes = new System.Windows.Forms.Button();
            this.Riddle = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.QCount = new System.Windows.Forms.Label();
            this.CorAnsCount = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.CorAnsCount);
            this.groupBox1.Controls.Add(this.QCount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.No);
            this.groupBox1.Controls.Add(this.Yes);
            this.groupBox1.Controls.Add(this.Riddle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ваш вопрос";
            // 
            // No
            // 
            this.No.Image = global::TrueFalseNew.Properties.Resources.delete_64px;
            this.No.Location = new System.Drawing.Point(127, 147);
            this.No.Name = "No";
            this.No.Size = new System.Drawing.Size(108, 69);
            this.No.TabIndex = 2;
            this.No.UseVisualStyleBackColor = true;
            this.No.Click += new System.EventHandler(this.No_Click);
            // 
            // Yes
            // 
            this.Yes.BackColor = System.Drawing.SystemColors.Menu;
            this.Yes.Image = global::TrueFalseNew.Properties.Resources.ok_64px;
            this.Yes.Location = new System.Drawing.Point(6, 147);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(114, 69);
            this.Yes.TabIndex = 1;
            this.Yes.UseVisualStyleBackColor = false;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // Riddle
            // 
            this.Riddle.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Riddle.Location = new System.Drawing.Point(6, 19);
            this.Riddle.Name = "Riddle";
            this.Riddle.Size = new System.Drawing.Size(379, 122);
            this.Riddle.TabIndex = 0;
            this.Riddle.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Задано вопросов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Количество правильных ответов:";
            // 
            // QCount
            // 
            this.QCount.AutoSize = true;
            this.QCount.Location = new System.Drawing.Point(492, 22);
            this.QCount.Name = "QCount";
            this.QCount.Size = new System.Drawing.Size(13, 13);
            this.QCount.TabIndex = 5;
            this.QCount.Text = "0";
            // 
            // CorAnsCount
            // 
            this.CorAnsCount.AutoSize = true;
            this.CorAnsCount.Location = new System.Drawing.Point(570, 39);
            this.CorAnsCount.Name = "CorAnsCount";
            this.CorAnsCount.Size = new System.Drawing.Size(13, 13);
            this.CorAnsCount.TabIndex = 6;
            this.CorAnsCount.Text = "0";
            // 
            // TrueFalseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "TrueFalseForm";
            this.Text = "Игра \"Верю-Не верю\"";
            this.Shown += new System.EventHandler(this.TrueFalseForm_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button No;
        private System.Windows.Forms.Button Yes;
        private System.Windows.Forms.RichTextBox Riddle;
        private System.Windows.Forms.Label CorAnsCount;
        private System.Windows.Forms.Label QCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}