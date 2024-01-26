namespace Inheritance.Models
{
    public class Student : User
    {
        public int RollNumber { get; set; }
        public Student() {
        }

        public Student(string name, string city, int rollNumber)
        {
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
