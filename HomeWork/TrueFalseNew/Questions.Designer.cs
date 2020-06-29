namespace TrueFalseNew
{
    partial class Questions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Questions));
            this.QuestionsTable = new System.Windows.Forms.DataGridView();
            this.Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YesOrNo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AboutProgram = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionsTable
            // 
            this.QuestionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuestionsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Question,
            this.YesOrNo});
            this.QuestionsTable.Location = new System.Drawing.Point(6, 36);
            this.QuestionsTable.Name = "QuestionsTable";
            this.QuestionsTable.Size = new System.Drawing.Size(764, 349);
            this.QuestionsTable.TabIndex = 0;
            // 
            // Question
            // 
            this.Question.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Question.HeaderText = "Вопрос";
            this.Question.Name = "Question";
            this.Question.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Question.Width = 50;
            // 
            // YesOrNo
            // 
            this.YesOrNo.HeaderText = "Правда/Ложь";
            this.YesOrNo.Name = "YesOrNo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AboutProgram);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ClearButton);
            this.groupBox1.Controls.Add(this.Save);
            this.groupBox1.Controls.Add(this.QuestionsTable);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 467);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список вопросов";
            // 
            // AboutProgram
            // 
            this.AboutProgram.AutoSize = true;
            this.AboutProgram.Image = global::TrueFalseNew.Properties.Resources.Que;
            this.AboutProgram.Location = new System.Drawing.Point(760, 16);
            this.AboutProgram.Name = "AboutProgram";
            this.AboutProgram.Size = new System.Drawing.Size(10, 13);
            this.AboutProgram.TabIndex = 4;
            this.AboutProgram.Text = " ";
            this.AboutProgram.Click += new System.EventHandler(this.AboutProgram_Click);
            // 
            // button1
            // 
            this.button1.Image = global::TrueFalseNew.Properties.Resources.synchronize_64px;
            this.button1.Location = new System.Drawing.Point(6, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 70);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Image = global::TrueFalseNew.Properties.Resources.Delete;
            this.ClearButton.Location = new System.Drawing.Point(695, 391);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 70);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "Очистить";
            this.ClearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // Save
            // 
            this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
            this.Save.Location = new System.Drawing.Point(616, 391);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(73, 70);
            this.Save.TabIndex = 1;
            this.Save.Text = "Сохранить";
            this.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.groupBox1);
            this.Name = "Questions";
            this.Text = "База данных";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Questions_FormClosed);
            this.Shown += new System.EventHandler(this.Questions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionsTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView QuestionsTable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.DataGridViewTextBoxColumn Question;
        private System.Windows.Forms.DataGridViewCheckBoxColumn YesOrNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label AboutProgram;
    }
}