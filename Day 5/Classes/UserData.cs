namespace UserData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Data
    {
        public Uri Avatar { get; set; }
        public string Status { get; set; }
        public List<Classroom> Classrooms { get; set; }
        public string Recent { get; set; }

        public Classroom GetClassroom(string name)
        {
            return Classrooms.FirstOrDefault(c => c.Name == name);
        }
    }

    public partial class Classroom
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }

        public Classroom(string name)
        {
            Name = name;
        }

        public Term GetStudent(string name, string term)
        {
            return Students.FirstOrDefault(s => s.Name == name).Terms.FirstOrDefault(t => t.Name == term);
        }
    }

    public partial class Student
    {
        public string Name { get; set; }
        public List<Term> Terms { get; set; }

        public Student(string name)
        {
            Name = name;
        }
    }

    public partial class Term
    {
        public string Name { get; set; }
        public Lecture Lecture { get; set; } = new Lecture();
        public HandsOn HandsOn { get; set; } = new HandsOn();
        public List<Graded> Laboratory { get; set; } = new List<Graded>();

        public Term(string name)
        {
            Name = name;
        }
    }

    public partial class HandsOn
    {
        public int Communication { get; set; } = 0;
        public int Teamwork { get; set; } = 0;
    }

    public partial class Graded
    {
        public string Name { get; set; }
        public int Score { get; set; } = 0;
        public int Total { get; set; } = 0;

        public Graded(string name, int score, int total)
        {
            Name = name;
            Score = score;
            Total = total;
        }
    }

    public partial class Lecture
    {
        public List<Graded> Exams { get; set; } = new List<Graded>();
        public int Recitation { get; set; } = 0;
    }
}