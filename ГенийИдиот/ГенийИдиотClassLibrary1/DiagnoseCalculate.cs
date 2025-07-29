namespace GeniyIdiot.Common
{
    public class DiagnoseCalculate
    {
        public static string GetDiagnose(int countRightAnswers, int countQuestions)
        {
            var percentRightQuestion = (double)countRightAnswers / countQuestions * 100;

            if (percentRightQuestion <= 20 && percentRightQuestion > 0) return "Кретин";
            if (percentRightQuestion <= 40 && percentRightQuestion > 20) return "Дурак";
            if (percentRightQuestion <= 60 && percentRightQuestion > 40) return "Нормальный";
            if (percentRightQuestion <= 80 && percentRightQuestion > 60) return "Талант";
            if (percentRightQuestion <= 100 && percentRightQuestion > 80) return "Гений";
            else return "Идиот";
        }
    }
}