using System.Collections.Generic;
using System.Threading;

namespace Quiz.Classes
{
    public class Questions
    {
        protected static int Id = 0;
        public int Page { get; set; }
        public int Correct { get; set; }
        public string Description { get; set; }
        public string[] Choices { get; set; }

        public Questions(string question, int correctAnswer, params string[] choices)
        {
            Page = Interlocked.Increment(ref Id);
            Description = question;
            Correct = correctAnswer;
            Choices = choices;
        }
    }

    public class Questionnaire
    {
        public List<Questions> Questions { get; set; } = new List<Questions>();
        public string Name;
    }
}