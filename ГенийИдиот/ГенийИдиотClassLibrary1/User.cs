namespace ГенийИдиотClassLibrary1
{
    public class User
    {
        public string Name;
        public int CountRightAnswers;
        public string Diagnose;

        public User(string name)
        {
            Name = name;
            Diagnose = "Не присвоен";
        }

        public void AcceptRightAnswer()
        {
            CountRightAnswers++;
        }
    }
}