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
            // variable inherited from parent class.
            Name = name;
            City = city;
            UserType = UserType.Teacher;

            Id = id;
            Subject = subject;
        }

        public string GetTeacherInformation()
        {
            return Name + " " + City + " " + Id + Subject;
        }

    }
}
