using Interface;

public class Program
{
    private static void Main(string[] args)
    {

        IShape shape = new Rectangle();

        shape.Display(shape);

        shape = new Triangle();

        shape.Display(shape);

               
    }
}