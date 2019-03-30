namespace MVVMTest.Models
{
    public class PersonModel
    {
        public PersonModel(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}