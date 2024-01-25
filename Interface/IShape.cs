namespace Interface;

public interface IShape
{
    // method
    void Display(IShape shape);
}

public class Rectangle : IShape
{
    private string Name = "I am Rectagle";

    public Rectangle()
    {
        
    }
    public void Display(IShape shape)
    {
        Console.WriteLine(Name);
    }
}

public class Triangle : IShape
{
    private string Name = "I am Triangle";

    public Triangle()
    {

    }
    public void Display(IShape shape)
    {
        Console.WriteLine(Name);
    }
}