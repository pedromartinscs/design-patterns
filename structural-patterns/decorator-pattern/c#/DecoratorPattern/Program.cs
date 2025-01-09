// Decorator pattern example
class Program
{
    static void Main(string[] args)
    {
        IComponent component = new ConcreteComponent();
        Console.WriteLine("Client: I've got a simple component:");
        Console.WriteLine(component.Operation());

        IComponent decorator1 = new ConcreteDecoratorA(component);
        IComponent decorator2 = new ConcreteDecoratorB(decorator1);
        Console.WriteLine("Client: Now I've got a decorated component:");
        Console.WriteLine(decorator2.Operation());
    }
}