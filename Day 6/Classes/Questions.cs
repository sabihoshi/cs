using System.Collections.Generic;
using System.Threading;

namespace Quiz.Classes
{
    public class Question
    {
        public int Page { get; set; }
        public int Correct { get; set; }
        public string Description { get; set; }
        public string[] Choices { get; set; }

        public Question(string question, int correctAnswer, params string[] choices)
        {
            Description = question;
            Correct = correctAnswer;
            Choices = choices;
        }
    }

    public class Questionnaire
    {
        public List<Question> Questions { get; set; } = new List<Question>();
        public string Name;
    }
}