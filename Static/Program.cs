public class Program
{
    private static void Main(string[] args)
    {

        User.Name = "Test";
        User.Password = "password";

        Console.WriteLine(User.Name);
        Console.WriteLine(User.Password);

        User user = new User();

        Console.WriteLine(user.Login());

    }
}

public class User
{
    public static string Name { get; set; }
    public static string Password { get; set; }
        
    public string Login()
    {
         return (Name + " " + Password);
    }

}