

// Class
using Class;

public class Program
{
    // Variables
    string Name;

    // Default Constructor / Parameterless Contructor
    public Program() { 
    

    }


    // Methods
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, Jhansi!");
        //Console.WriteLine("USA!");
        //Console.WriteLine("New York");

        //Console.ReadKey();

        // Class / user defined / 
        Dog dog = new Dog();

        Console.WriteLine(dog.GetName());
        Console.WriteLine(dog.GetDescription());
    }
}