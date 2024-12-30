// Client
class Program
{
    static void Main(string[] args)
    {
        Mediator mediator = new Mediator();

        ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
        ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);

        mediator.Register(colleague1);
        mediator.Register(colleague2);

        colleague1.Send("Hello from Colleague1");
        colleague2.Send("Hello from Colleague2");
    }
}