using System.Collections.Generic;
using System.Threading;

namespace Quiz.Classes
{
	public class Question
	{
		protected static int Id;

		public Question(string question, int correctAnswer, params string[] choices)
		{
			Page = Interlocked.Increment(ref Id);
			Description = question;
			Correct = correctAnswer;
			Choices = choices;
		}

		public int Page { get; set; }
		public int Correct { get; set; }
		public string Description { get; set; }
		public string[] Choices { get; set; }
	}

	public class Questionnaire
	{
		public string Name;
		public List<Question> Questions { get; set; } = new List<Question>();
	}
}