using System.Collections.Generic;

namespace CIIT_Grading_System.Classes
{
    public class GradeTemplate
    {
        public class TableGradeClass
        {
            public List<List<string>> Lectures { get; set; } = new List<List<string>>();
            public List<List<string>> Laboratory { get; set; } = new List<List<string>>();
            public List<List<string>> HandsOn { get; set; } = new List<List<string>>();
            public List<string> Total { get; set; } = new List<string>();
        }

        public TableGradeClass Table { get; set; } = new TableGradeClass();

        public class Recorded
        {
            public double Total { get; set; } = 0;
            public double Score { get; set; } = 0;
            public double Percentage { get; set; } = 0;
        }

        public class LecturesClass
        {
            public Recorded Exams { get; set; } = new Recorded();
            public double Recitation { get; set; } = 0;
            public Recorded Attendance { get; set; } = new Recorded();
            public double Percentage { get; set; } = 0;
        }

        public class HandsOnClass
        {
            public double Communication { get; set; } = 0;
            public double Teamwork { get; set; } = 0;
            public double Percentage { get; set; } = 0;
        }

        public LecturesClass Lectures { get; set; } = new LecturesClass();
        public HandsOnClass HandsOn { get; set; } = new HandsOnClass();
        public Recorded Laboratory { get; set; } = new Recorded();
    }
}