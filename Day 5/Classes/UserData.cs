using System.Collections.Generic;
using System.Linq;

namespace UserData
{
	public class Data
	{
		public List<Classroom> Classrooms { get; set; }
		public string Recent { get; set; }

		public Classroom GetClassroom(string name)
		{
			return Classrooms.FirstOrDefault(c => c.Name == name);
		}
	}

	public class Classroom
	{
		public Classroom(string name)
		{
			Name = name;
		}

		public string Name { get; set; }
		public List<Student> Students { get; set; }
	}

	public class Student
	{
		public Student(string name)
		{
			Name = name;
		}

		public string Name { get; set; }
		public List<Term> Terms { get; set; }
	}

	public class Term
	{
		public Term(string name)
		{
			Name = name;
		}

		public string Name { get; set; }
		public Lecture Lecture { get; set; } = new Lecture();
		public HandsOn HandsOn { get; set; } = new HandsOn();
		public List<Graded> Laboratory { get; set; } = new List<Graded>();
	}

	public class HandsOn
	{
		public double Communication { get; set; } = 0;
		public double Teamwork { get; set; } = 0;
	}

	public class Graded
	{
		public Graded(string name, double score, double total)
		{
			Name = name;
			Score = score;
			Total = total;
		}

		public string Name { get; set; }
		public double Score { get; set; }
		public double Total { get; set; }
	}

	public class Lecture
	{
		public List<Graded> Exams { get; set; } = new List<Graded>();
		public double Recitation { get; set; } = 0;
	}
}