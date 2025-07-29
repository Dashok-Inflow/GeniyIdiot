namespace ГенийИдиотWindowsFormsApp1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.questionNumberLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showQuestionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.getAnswerTimer = new System.Windows.Forms.Timer(this.components);
            this.showTimerLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionNumberLabel
            // 
            this.questionNumberLabel.AutoSize = true;
            this.questionNumberLabel.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionNumberLabel.Location = new System.Drawing.Point(29, 68);
            this.questionNumberLabel.Name = "questionNumberLabel";
            this.questionNumberLabel.Size = new System.Drawing.Size(190, 38);
            this.questionNumberLabel.TabIndex = 1;
            this.questionNumberLabel.Text = "Вопрос №1";
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextLabel.Location = new System.Drawing.Point(32, 153);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(179, 30);
            this.questionTextLabel.TabIndex = 2;
            this.questionTextLabel.Text = "Текст вопроса";
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.userAnswerTextBox.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAnswerTextBox.Location = new System.Drawing.Point(36, 225);
            this.userAnswerTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(365, 50);
            this.userAnswerTextBox.TabIndex = 0;
            // 
            // nextButton
            // 
            this.nextButton.Font = new System.Drawing.Font("Modern No. 20", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(313, 420);
            this.nextButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(216, 87);
            this.nextButton.TabIndex = 0;
            this.nextButton.Text = "Далее";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюToolStripMenuItem
            // 
            this.менюToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restartToolStripMenuItem,
            this.showResultsToolStripMenuItem,
            this.exitToolStripMenuItem,
            this.showQuestionsToolStripMenuItem});
            this.менюToolStripMenuItem.Name = "менюToolStripMenuItem";
            this.менюToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.менюToolStripMenuItem.Text = "Меню";
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.restartToolStripMenuItem.Text = "Перезапустить игру";
            this.restartToolStripMenuItem.Click += new System.EventHandler(this.restartToolStripMenuItem_Click);
            // 
            // showResultsToolStripMenuItem
            // 
            this.showResultsToolStripMenuItem.Name = "showResultsToolStripMenuItem";
            this.showResultsToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.showResultsToolStripMenuItem.Text = "Показать результаты игры";
            this.showResultsToolStripMenuItem.Click += new System.EventHandler(this.showResultsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.exitToolStripMenuItem.Text = "Выйти из игры";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // showQuestionsToolStripMenuItem
            // 
            this.showQuestionsToolStripMenuItem.Name = "showQuestionsToolStripMenuItem";
            this.showQuestionsToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.showQuestionsToolStripMenuItem.Text = "Показать список вопросов";
            this.showQuestionsToolStripMenuItem.Click += new System.EventHandler(this.showQuestionsToolStripMenuItem_Click);
            // 
            // getAnswerTimer
            // 
            this.getAnswerTimer.Interval = 1000;
            this.getAnswerTimer.Tick += new System.EventHandler(this.getAnswerTimer_Tick);
            // 
            // showTimerLabel
            // 
            this.showTimerLabel.AutoSize = true;
            this.showTimerLabel.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showTimerLabel.Location = new System.Drawing.Point(298, 318);
            this.showTimerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showTimerLabel.Name = "showTimerLabel";
            this.showTimerLabel.Size = new System.Drawing.Size(31, 35);
            this.showTimerLabel.TabIndex = 5;
            this.showTimerLabel.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 324);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Обратный отсчёт:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.showTimerLabel);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.questionNumberLabel);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.Text = "Гений-Идиот";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label questionNumberLabel;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.TextBox userAnswerTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showQuestionsToolStripMenuItem;
        private System.Windows.Forms.Timer getAnswerTimer;
        private System.Windows.Forms.Label showTimerLabel;
        private System.Windows.Forms.Label label2;
    }
}

