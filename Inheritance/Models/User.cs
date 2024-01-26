namespace Inheritance.Models;


// Access Modifier
public class User
{

    // Variable

    // Access Modifier / Data Type / User Defined
    public string Name { get; set; }
    public string City { get; set; }

    public UserType UserType { get; set; }

    // Constructor

    // Access Modifier / Constructor Name (Class Name)
    public User()
    {
    }

    // parameterised constructor
    public User(string name, string city)
    {
        Name = name;
        City = city;
    }


    // Methods
    // Access Modifier / Return Type / User Defined Name
    public string GetUserInformartion()
    {
        return Name + " " + City + " " + UserType;
    }
}

public enum UserType
{
    Student,
    Teacher
}

// One Class parent another will Child.
