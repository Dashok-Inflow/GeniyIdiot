using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace GeniyIdiot.Common
{
    public class QuestionStorage
    {
        public static string Path = "Список вопросов.json";
        public static List<Question> GetAll()
        {
            var questions = new List<Question>();
            if (FileProvider.CheckFile(Path))
            {
                var value = FileProvider.GetValue(Path);
                questions=JsonConvert.DeserializeObject<List<Question>>(value);
            }
            else
            {
                questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
                questions.Add(new Question("Бревно нужно поделить на 10 частей. Сколько нужно сделать распилов?", 9));
                questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
                questions.Add(new Question("Укол делают каждые полчаса. Сколько нужно минут для трёх уколов?", 60));
                questions.Add(new Question("Пять свечей сгорело, две потухли. Сколько свечей осталось?", 2));

                SaveQuestions(questions);
            }
            return questions;
        }

        public static void SaveQuestions(List<Question> questions)
        {
            var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
            FileProvider.Replace(Path, jsonData);
        }

        public static void Add(Question newQuestion)
        {
            var questions = GetAll();
            questions.Add(newQuestion);
            SaveQuestions(questions);
        }

        public static void Remove(Question removeQuestion)
        {
            var questions = GetAll();
            
            for(int k=0;k<questions.Count;k++)
            {
                if (questions[k].Text== removeQuestion.Text)
                {
                    questions.RemoveAt(k);
                    break;
                }
            }
            SaveQuestions(questions);
        }
    }
}