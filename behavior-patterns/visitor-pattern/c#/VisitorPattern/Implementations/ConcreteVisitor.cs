
// Concrete Visitor
public class ConcreteVisitor : IVisitor
{
    public void Visit(ElementA element)
    {
        Console.WriteLine("Visited ElementA");
    }

    public void Visit(ElementB element)
    {
        Console.WriteLine("Visited ElementB");
    }
}
