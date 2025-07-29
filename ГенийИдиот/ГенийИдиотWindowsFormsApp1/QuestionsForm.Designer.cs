namespace ГенийИдиотWindowsFormsApp1
{
    partial class QuestionsForm
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
            this.components = new System.ComponentModel.Container();
            this.showQuestionsDataGridView = new System.Windows.Forms.DataGridView();
            this.numberQuestionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.questionTextColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionsWithQuestionContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionAnswerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addNewQuestionGroupBox = new System.Windows.Forms.GroupBox();
            this.addButton = new System.Windows.Forms.Button();
            this.questionAnswerTextBox = new System.Windows.Forms.TextBox();
            this.questionTextTextBox = new System.Windows.Forms.TextBox();
            this.questionAnswerLabel = new System.Windows.Forms.Label();
            this.questionTextLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.showQuestionsDataGridView)).BeginInit();
            this.actionsWithQuestionContextMenuStrip.SuspendLayout();
            this.addNewQuestionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // showQuestionsDataGridView
            // 
            this.showQuestionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showQuestionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberQuestionColumn,
            this.questionTextColumn,
            this.questionAnswerColumn});
            this.showQuestionsDataGridView.ContextMenuStrip = this.actionsWithQuestionContextMenuStrip;
            this.showQuestionsDataGridView.Location = new System.Drawing.Point(16, 15);
            this.showQuestionsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showQuestionsDataGridView.Name = "showQuestionsDataGridView";
            this.showQuestionsDataGridView.RowHeadersWidth = 51;
            this.showQuestionsDataGridView.Size = new System.Drawing.Size(695, 218);
            this.showQuestionsDataGridView.TabIndex = 0;
            // 
            // numberQuestionColumn
            // 
            this.numberQuestionColumn.HeaderText = "Номер вопроса";
            this.numberQuestionColumn.MinimumWidth = 6;
            this.numberQuestionColumn.Name = "numberQuestionColumn";
            this.numberQuestionColumn.Width = 70;
            // 
            // questionTextColumn
            // 
            this.questionTextColumn.ContextMenuStrip = this.actionsWithQuestionContextMenuStrip;
            this.questionTextColumn.HeaderText = "Текст вопроса";
            this.questionTextColumn.MinimumWidth = 6;
            this.questionTextColumn.Name = "questionTextColumn";
            this.questionTextColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.questionTextColumn.Width = 500;
            // 
            // actionsWithQuestionContextMenuStrip
            // 
            this.actionsWithQuestionContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.actionsWithQuestionContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteQuestionToolStripMenuItem});
            this.actionsWithQuestionContextMenuStrip.Name = "actionsWithQuestionContextMenuStrip";
            this.actionsWithQuestionContextMenuStrip.Size = new System.Drawing.Size(190, 28);
            // 
            // deleteQuestionToolStripMenuItem
            // 
            this.deleteQuestionToolStripMenuItem.Name = "deleteQuestionToolStripMenuItem";
            this.deleteQuestionToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.deleteQuestionToolStripMenuItem.Text = "Удалить вопрос";
            this.deleteQuestionToolStripMenuItem.Click += new System.EventHandler(this.deleteQuestionToolStripMenuItem_Click);
            // 
            // questionAnswerColumn
            // 
            this.questionAnswerColumn.HeaderText = "Ответ на вопрос";
            this.questionAnswerColumn.MinimumWidth = 6;
            this.questionAnswerColumn.Name = "questionAnswerColumn";
            this.questionAnswerColumn.Width = 70;
            // 
            // addNewQuestionGroupBox
            // 
            this.addNewQuestionGroupBox.Controls.Add(this.addButton);
            this.addNewQuestionGroupBox.Controls.Add(this.questionAnswerTextBox);
            this.addNewQuestionGroupBox.Controls.Add(this.questionTextTextBox);
            this.addNewQuestionGroupBox.Controls.Add(this.questionAnswerLabel);
            this.addNewQuestionGroupBox.Controls.Add(this.questionTextLabel);
            this.addNewQuestionGroupBox.Location = new System.Drawing.Point(16, 255);
            this.addNewQuestionGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addNewQuestionGroupBox.Name = "addNewQuestionGroupBox";
            this.addNewQuestionGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addNewQuestionGroupBox.Size = new System.Drawing.Size(695, 365);
            this.addNewQuestionGroupBox.TabIndex = 1;
            this.addNewQuestionGroupBox.TabStop = false;
            this.addNewQuestionGroupBox.Text = "Добавление нового вопроса";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(243, 263);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(229, 75);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Добавить";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // questionAnswerTextBox
            // 
            this.questionAnswerTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionAnswerTextBox.Location = new System.Drawing.Point(14, 207);
            this.questionAnswerTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.questionAnswerTextBox.Name = "questionAnswerTextBox";
            this.questionAnswerTextBox.Size = new System.Drawing.Size(587, 29);
            this.questionAnswerTextBox.TabIndex = 3;
            // 
            // questionTextTextBox
            // 
            this.questionTextTextBox.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextTextBox.Location = new System.Drawing.Point(15, 90);
            this.questionTextTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.questionTextTextBox.Name = "questionTextTextBox";
            this.questionTextTextBox.Size = new System.Drawing.Size(586, 29);
            this.questionTextTextBox.TabIndex = 2;
            // 
            // questionAnswerLabel
            // 
            this.questionAnswerLabel.AutoSize = true;
            this.questionAnswerLabel.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionAnswerLabel.Location = new System.Drawing.Point(9, 146);
            this.questionAnswerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionAnswerLabel.Name = "questionAnswerLabel";
            this.questionAnswerLabel.Size = new System.Drawing.Size(339, 31);
            this.questionAnswerLabel.TabIndex = 1;
            this.questionAnswerLabel.Text = "Введите ответ на вопрос:";
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextLabel.Location = new System.Drawing.Point(8, 36);
            this.questionTextLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(407, 31);
            this.questionTextLabel.TabIndex = 0;
            this.questionTextLabel.Text = "Введите текст нового вопроса:";
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 656);
            this.Controls.Add(this.addNewQuestionGroupBox);
            this.Controls.Add(this.showQuestionsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuestionsForm";
            this.Text = "Гений-Идиот, список вопросов";
            this.Load += new System.EventHandler(this.QuestionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showQuestionsDataGridView)).EndInit();
            this.actionsWithQuestionContextMenuStrip.ResumeLayout(false);
            this.addNewQuestionGroupBox.ResumeLayout(false);
            this.addNewQuestionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView showQuestionsDataGridView;
        private System.Windows.Forms.ContextMenuStrip actionsWithQuestionContextMenuStrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberQuestionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionTextColumn;
        private System.Windows.Forms.ToolStripMenuItem deleteQuestionToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn questionAnswerColumn;
        private System.Windows.Forms.GroupBox addNewQuestionGroupBox;
        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.Label questionAnswerLabel;
        private System.Windows.Forms.TextBox questionTextTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox questionAnswerTextBox;
    }
}