using Inheritance.Models;

public class Program
{
    private static void Main(string[] args)
    {
        
        Teacher teacher = new Teacher("Shailendra", "New York", 10, "IT");

        Console.WriteLine(" User Details : " + teacher.GetUserInformartion());

        Student user = new Student("Mahesh", "New York",123);
        Console.WriteLine(" User Details : " + user.GetUserInformartion());

    }
}