namespace Inheritance.Models
{
    public class Student : User
    {
        public int RollNumber { get; set; }
        public Student() {
        }

        // parameterise constructor
        public Student(string name, string city, int rollNumber)
        {
            // variable inherited from parent class.
            Name = name;
            City = city;
            UserType = UserType.Student;

            RollNumber = rollNumber;
        }

        public string GetStudentInformation()
        {
            return Name + " " + City + " " + RollNumber;
        }

    }
}
