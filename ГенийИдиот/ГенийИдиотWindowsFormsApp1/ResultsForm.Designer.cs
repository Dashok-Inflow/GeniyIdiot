namespace ГенийИдиотWindowsFormsApp1
{
    partial class ResultsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.showUsersResultsDataGridView = new System.Windows.Forms.DataGridView();
            this.userNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countRightAnswersColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnoseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.showUsersResultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // showUsersResultsDataGridView
            // 
            this.showUsersResultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showUsersResultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userNameColumn,
            this.countRightAnswersColumn,
            this.diagnoseColumn});
            this.showUsersResultsDataGridView.Location = new System.Drawing.Point(1, 0);
            this.showUsersResultsDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showUsersResultsDataGridView.Name = "showUsersResultsDataGridView";
            this.showUsersResultsDataGridView.RowHeadersWidth = 51;
            this.showUsersResultsDataGridView.Size = new System.Drawing.Size(723, 406);
            this.showUsersResultsDataGridView.TabIndex = 0;
            // 
            // userNameColumn
            // 
            this.userNameColumn.HeaderText = "Имя";
            this.userNameColumn.MinimumWidth = 6;
            this.userNameColumn.Name = "userNameColumn";
            this.userNameColumn.ReadOnly = true;
            this.userNameColumn.Width = 150;
            // 
            // countRightAnswersColumn
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = null;
            this.countRightAnswersColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.countRightAnswersColumn.HeaderText = "Кол-во верных ответов";
            this.countRightAnswersColumn.MinimumWidth = 6;
            this.countRightAnswersColumn.Name = "countRightAnswersColumn";
            this.countRightAnswersColumn.Width = 200;
            // 
            // diagnoseColumn
            // 
            this.diagnoseColumn.HeaderText = "Диагноз";
            this.diagnoseColumn.MinimumWidth = 6;
            this.diagnoseColumn.Name = "diagnoseColumn";
            this.diagnoseColumn.Width = 150;
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 410);
            this.Controls.Add(this.showUsersResultsDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ResultsForm";
            this.Text = "Гений-Идиот, результаты игры";
            this.Load += new System.EventHandler(this.UsersResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showUsersResultsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView showUsersResultsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countRightAnswersColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnoseColumn;
    }
}