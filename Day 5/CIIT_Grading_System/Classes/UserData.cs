namespace UserData
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public partial class Data
    {
        public Uri Avatar { get; set; }
        public string Status { get; set; }
        public List<Classroom> Classrooms { get; set; } = new List<Classroom>();
        public string Recent { get; set; }

        public Classroom GetClassroom(string name)
        {
            return Classrooms.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void CreateClassroom(string name)
        {
            Classrooms.Add(new Classroom
            {
                Name = name
            });
        }
    }

    public partial class Classroom
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();

        public Student GetStudent(string name)
        {
            return Students.FirstOrDefault(s => s.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public void CreateStudent(string name)
        {
            Students.Add(new Student
            {
                Name = name
            });
        }
    }

    public partial class Student
    {
        public string Name { get; set; }
        public Lecture Lecture { get; set; } = new Lecture();
        public List<Graded> Laboratory { get; set; } = new List<Graded>();
        public HandsOn HandsOn { get; set; } = new HandsOn();
    }

    public partial class HandsOn
    {
        public int Communication { get; set; }
        public int Teamwork { get; set; }
    }

    public partial class Graded
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Total { get; set; }
    }

    public partial class Lecture
    {
        public List<Graded> Exams { get; set; } = new List<Graded>();
        public long Recitation { get; set; }
    }
}