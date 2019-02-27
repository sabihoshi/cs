using System.Collections.Generic;

namespace Quiz.Classes
{
    public class Questioned
    {
        public int Page { get; set; }
        public int Correct { get; set; }
        public string Question { get; set; }
        public List<string> Choices { get; set; } = new List<string>();

        public void CreateChoice(List<string> choices_to_add)
        {
            foreach (string item in choices_to_add)
            {
                Choices.Add(item);
            }
        }
    }

    public class Questionnaires
    {
        public List<Questioned> Questions { get; set; } = new List<Questioned>();

        public void CreateQuestion(string question)
        {
            Questions.Add(new Questioned
            {
                Question = question,
                Page = Questions.Count + 1
            });
        }
    }
}