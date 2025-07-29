using System;
using ГенийИдиотClassLibrary1;

namespace ГенийИдиотConsoleApp1
{
    internal class Program
    {
        public static bool Yes(string userAnswer)
        {
            if (userAnswer.ToLower() == "да") return true;
            else return false;
        }

        static void Main()
        { 
            Console.WriteLine("Введите своё имя:");
            var userName = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {userName}! Мы рады вас приветствовать на прототипе приложения Гений-Идиот!\nВы хотите пройти тест?");
            var userAnswer = Console.ReadLine();
            var user = new User(userName);
            

            while (Yes(userAnswer))
            {
                var questions = QuestionStorage.GetAll();
                var countQuestions = questions.Count;
                Random rnd = new Random();

                for (int k = 0; k < countQuestions; k++)
                {
                    var randomIndex = rnd.Next(0, questions.Count);

                    Console.WriteLine("Вопрос №" + (k + 1));
                    Console.WriteLine(questions[randomIndex].Text);
                    int userNumberAnswer = 0;
                    userNumberAnswer = GetAnswer();
                    if (userNumberAnswer == questions[randomIndex].Answer) user.AcceptRightAnswer();
                    questions.RemoveAt(randomIndex);
                }
                var diagnose = DiagnoseCalculate.GetDiagnose(user.CountRightAnswers, countQuestions);
                
                Console.WriteLine($"Кол-во верных ответов: {user.CountRightAnswers}\n{userName}, ваш диагноз: {diagnose}");
                user.Diagnose= diagnose;
                UserStorage.SaveUserResults(user);

                Console.WriteLine("Вы хотите посмотреть все результаты тестирования?");
                userAnswer = Console.ReadLine();
                if (Yes(userAnswer))
                {
                    ShowUsersResult();
                }

                Console.WriteLine("Вы хотите добавить новый вопрос?");
                userAnswer = Console.ReadLine();
                if (Yes(userAnswer))
                {
                    AddNewQuestion();
                }

                Console.WriteLine("Вы хотите удалить существующий вопрос?");
                userAnswer = Console.ReadLine();
                if (Yes(userAnswer))
                {
                    RemoveQuestion();
                }

                Console.WriteLine("Вы хотите пройти тест повторно?");
                userAnswer = Console.ReadLine();
            }
        }

        public static void RemoveQuestion()
        {
            var questions = QuestionStorage.GetAll();
            for (int k=0;k<questions.Count;k++)
            {
                Console.WriteLine((k + 1) + ". " + questions[k].Text);
            }

            Console.WriteLine("Введите номер вопроса, который вы хотите удалить.");
            var removeQuestionNumber = GetAnswer();
            while(removeQuestionNumber <1 || removeQuestionNumber > questions.Count)
            {
                Console.WriteLine("Такого вопроса не существует! Введите номер существующего вопроса");
                removeQuestionNumber = GetAnswer();
            }

            var removeQuestion = questions[removeQuestionNumber - 1];
            QuestionStorage.Remove(removeQuestion);
        }

        public static void AddNewQuestion()
        {
            Console.WriteLine("Введите новый вопрос:");
            var question = Console.ReadLine();
            Console.WriteLine("Введите ответ на данный вопрос:");
            var answer = GetAnswer();

            var newQuestion=new Question(question, answer);
            QuestionStorage.Add(newQuestion);
        }
        public static void ShowUsersResult()
        {
            var result = UserStorage.GetUsersResults();
            foreach(var user in result)
            {
                Console.WriteLine($"{user.Name,-11}|{user.CountRightAnswers,-21}|{user.Diagnose,-11}");
            }
        }

        public static int GetAnswer()
        {
            int userNumberAnswer = 0;
            try
            {
                userNumberAnswer = Int32.Parse(Console.ReadLine());
            }
            catch
            {
                bool answer = true;
                do
                {
                    Console.WriteLine("Вы ввели не число! Повторите попытку");
                    string repeatAnswer = Console.ReadLine();

                    if (int.TryParse(repeatAnswer, out int number))
                    {
                        Console.WriteLine("Отлично! Теперь ваш ответ корректный!");
                        userNumberAnswer = number;
                        answer = false;
                    }
                }
                while (answer);
            }
            return userNumberAnswer;
        }
    }
}