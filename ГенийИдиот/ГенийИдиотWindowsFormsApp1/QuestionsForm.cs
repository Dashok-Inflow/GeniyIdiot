using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GeniyIdiot.Common;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class QuestionsForm : Form
    {
        private List<Question> questions;
        public QuestionsForm()
        {
            InitializeComponent();
        }

        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            questions = QuestionStorage.GetAll();

            ShowQuestions();
        }

        private void ShowQuestions()
        {
            for(int k=0;k<questions.Count;k++)
            {
                showQuestionsDataGridView.Rows.Add(k + 1, questions[k].Text, questions[k].Answer);
            }
        }

        private void deleteQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = showQuestionsDataGridView.CurrentRow.Index-1;
            var deleteQuestion=questions[index];
            QuestionStorage.Remove(deleteQuestion);

            DialogResult result = MessageBox.Show("Вопрос успешно удалён. После нажатия кнопки ОК окно автоматически закроется", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var questionText = questionTextTextBox.Text;

            var questionAnswer = questionAnswerTextBox.Text;
            if (int.TryParse(questionAnswer,out int questionCorrectAnswer))
            {
                var newQuestion = new Question(questionText, questionCorrectAnswer);
                QuestionStorage.Add(newQuestion);
                var result=MessageBox.Show("Вопрос успешно добавлен. После нажатия кнопки ОК окно автоматически закроется", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
            {
                questionAnswerTextBox.Clear();
                MessageBox.Show("Ответ на вопрос должен быть цифрой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
