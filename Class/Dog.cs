namespace Class;


// Access Modifier
public class Dog
{

    // Variable

    // Access Modifier / Data Type / User Defined
    private string Name = "Tobi";
    private string Description = "Tobi is cute, and is 2 years old, color brown";

    // Constructor

    // Access Modifier / Constructor Name (Class Name)
    public Dog()
    {
        Name = "Mr Tobi";
    }


    // Methods
    // Access Modifier / Return Type / User Defined Name
    public string GetName()
    {
        return Name;
    }

    public string GetDescription()
    {
        return Description;
    }
}
