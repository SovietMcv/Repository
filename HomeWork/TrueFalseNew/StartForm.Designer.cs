namespace TrueFalseNew
{
    partial class StartForm
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
            this.Game = new System.Windows.Forms.Button();
            this.BDStart = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Exit);
            this.groupBox1.Controls.Add(this.Game);
            this.groupBox1.Controls.Add(this.BDStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Что хотите запустить?";
            // 
            // Game
            // 
            this.Game.Location = new System.Drawing.Point(98, 84);
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(95, 23);
            this.Game.TabIndex = 1;
            this.Game.Text = "Запуск игры";
            this.Game.UseVisualStyleBackColor = true;
            this.Game.Click += new System.EventHandler(this.Game_Click);
            // 
            // BDStart
            // 
            this.BDStart.Location = new System.Drawing.Point(98, 55);
            this.BDStart.Name = "BDStart";
            this.BDStart.Size = new System.Drawing.Size(95, 23);
            this.BDStart.TabIndex = 0;
            this.BDStart.Text = "Запуск БД";
            this.BDStart.UseVisualStyleBackColor = true;
            this.BDStart.Click += new System.EventHandler(this.BdStart_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(98, 113);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(95, 23);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 203);
            this.Controls.Add(this.groupBox1);
            this.Name = "StartForm";
            this.Text = "Стартовая страница";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BDStart;
        private System.Windows.Forms.Button Game;
        private System.Windows.Forms.Button Exit;
    }
}

