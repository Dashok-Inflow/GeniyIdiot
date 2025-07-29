using System;
using System.Windows.Forms;
using GeniyIdiot.Common;
using System.Collections.Generic;

namespace GeniyIdiotWindowsFormsApp
{
    public partial class MainForm : Form
    {
        private List<Question> questions;
        private Question currentQuestion;
        private User user;
        private int countQuestions;
        private int questionNumber = 0;
        private int time;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            time = 10;

            var welcomeForm = new WelcomeForm(getAnswerTimer);
            welcomeForm.ShowDialog();

            user = new User(welcomeForm.userNameTextBox.Text);

            questions = QuestionStorage.GetAll();
            countQuestions = questions.Count;

            ShowNextQuestion();
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            time = 10;
            userAnswerTextBox.Focus();
            var userAnswer = userAnswerTextBox.Text;

            if (int.TryParse(userAnswer, out int userCorrectAnswer))
            {
                var rightAnswer = currentQuestion.Answer;
                if (userCorrectAnswer == rightAnswer)
                {
                    user.AcceptRightAnswer();
                }
                questions.Remove(currentQuestion);
                userAnswerTextBox.Clear();

                var endGame = questions.Count == 0;
                if (endGame)
                {
                    user.Diagnose = DiagnoseCalculate.GetDiagnose(user.CountRightAnswers, countQuestions);
                    UserStorage.SaveUserResults(user);
                    MessageBox.Show(user.Name + ", ваш результат успешно сохранён", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getAnswerTimer.Stop();
                    nextButton.Enabled = false;
                    return;
                }

                ShowNextQuestion();
            }
            else
            {
                MessageBox.Show("Ваш ответ засчитан как неправильный." +
                    "\nВаша строка пустая или содержит не число!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                questions.Remove(currentQuestion);
                userAnswerTextBox.Clear();

                var endGame = questions.Count == 0;
                if (endGame)
                {
                    user.Diagnose = DiagnoseCalculate.GetDiagnose(user.CountRightAnswers, countQuestions);
                    UserStorage.SaveUserResults(user);
                    MessageBox.Show(user.Name + ", ваш результат успешно сохранён", "Сохранение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getAnswerTimer.Stop();
                    nextButton.Enabled = false;
                    return;
                }

                ShowNextQuestion();
            }
        }

        private void ShowNextQuestion()
        {
            Random rnd = new Random();
            var randomIndex = rnd.Next(0, questions.Count);

            currentQuestion=questions[randomIndex];
            questionTextLabel.Text = currentQuestion.Text;

            questionNumber++;
            questionNumberLabel.Text = "Вопрос №" + questionNumber;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitGame = MessageBox.Show("Вы уверены, что хотите покинуть игру?", "Выход из игры", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (exitGame == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void showResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var results = new ResultsForm();
            results.ShowDialog();
        }

        private void showQuestionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuestionsForm questions = new QuestionsForm();
            questions.ShowDialog();
        }

        private void getAnswerTimer_Tick(object sender, EventArgs e)
        {
            time = time - 1;
            showTimerLabel.Text = Convert.ToString(time);

            if (time==0)
            {
                getAnswerTimer.Stop();
                var sms=MessageBox.Show("Время вышло! Ответ будет засчитан как неправильный", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(sms== DialogResult.OK)
                {
                    nextButton_Click(null, null);
                    getAnswerTimer.Start();
                }
            }
        }
    }
}
