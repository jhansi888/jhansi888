using System.Security.Cryptography.X509Certificates;

namespace Inheritance.Models
{
    public class Teacher : User
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public Teacher() {
        }

        public Teacher(string name, string city, int id, string subject)
        {
            Name = name;
            City = city;
            Id = id;
            UserType = UserType.Teacher;
            Subject = subject;
        }

        public string GetTeacherInformation()
        {
            return Name + " " + City + " " + Id + Subject;
        }

    }
}
