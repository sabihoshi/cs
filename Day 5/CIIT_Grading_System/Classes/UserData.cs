using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIIT_Grading_System.Classes
{
    public class Rootobject
    {
        public string Avatar { get; set; }
        public string Status { get; set; }
        public Classroom[] Classrooms { get; set; }
        public string Recent { get; set; }
    }

    public class Classroom
    {
        public string Name { get; set; }
        public Student[] Students { get; set; }
    }

    public class Student
    {
        public string Name { get; set; }
        public Lecture Lecture { get; set; }
        public Laboratory[] Laboratory { get; set; }
        public HandsOn Handson { get; set; }
    }

    public class Lecture
    {
        public Exam[] Exams { get; set; }
        public int Recitation { get; set; }
    }

    public class Exam
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Total { get; set; }
    }

    public class HandsOn
    {
        public int Communication { get; set; }
        public int Teamwork { get; set; }
    }

    public class Laboratory
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public int Total { get; set; }
    }
}