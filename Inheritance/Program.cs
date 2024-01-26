using Inheritance.Models;

public class Program
{
    private static void Main(string[] args)
    {
        //Student student = new Student("Jhansi", "New York", 122);

        //Console.WriteLine(" Student Details : " + student.GetStudentInformation());
        //Console .WriteLine(" User Details : " + student.GetUserInformartion());


        Teacher teacher = new Teacher("Shailendra", "New York", 10, "IT");

        Console.WriteLine(" User Details : " + teacher.GetUserInformartion());


        Student user = new Student("Mahesh", "New York",123);
        Console.WriteLine(" User Details : " + user.GetUserInformartion());





    }
}