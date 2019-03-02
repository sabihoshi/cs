using System.Collections.Generic;

namespace CIIT_Grading_System.Classes
{
    internal class GradeTemplate
    {
        public class TableGradeClass
        {
            public List<List<string>> Lectures { get; set; } = new List<List<string>>();
            public List<List<string>> Laboratory { get; set; } = new List<List<string>>();
            public List<List<string>> HandsOn { get; set; } = new List<List<string>>();
            public List<string> Total { get; set; } = new List<string>();
        }

        public TableGradeClass Table { get; set; } = new TableGradeClass();

        public class GradeClass
        {
            public int Total { get; set; } = 0;
            public int Score { get; set; } = 0;
            public double Percentage { get; set; } = 0;
        }

        public class LecturesClass
        {
            public GradeClass Exams { get; set; } = new GradeClass();
            public GradeClass Recitation { get; set; } = new GradeClass();
            public GradeClass Attendance { get; set; } = new GradeClass();
            public double Percentage { get; set; } = 0;
        }

        public class HandsOnClass
        {
            public GradeClass Communication { get; set; } = new GradeClass();
            public GradeClass Teamwork { get; set; } = new GradeClass();
            public double Percentage { get; set; } = 0;
        }

        public LecturesClass Lectures { get; set; } = new LecturesClass();
        public HandsOnClass HandsOn { get; set; } = new HandsOnClass();
        public GradeClass Laboratory { get; set; } = new GradeClass();
    }
}