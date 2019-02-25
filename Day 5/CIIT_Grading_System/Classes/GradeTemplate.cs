using System.Collections.Generic;

namespace CIIT_Grading_System.Classes
{
    internal class GradeTemplate
    {
        public class Grade
        {
            public List<List<string>> Lectures { get; set; }
            public List<List<string>> Laboratory { get; set; }
            public List<List<string>> HandsOn { get; set; }
            public List<string> Total { get; set; }
        }

        public Grade MidTerm { get; set; }
        public Grade FinTerm { get; set; }
    }
}