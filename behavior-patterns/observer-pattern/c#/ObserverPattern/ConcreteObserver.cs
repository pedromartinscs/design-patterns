
// Concrete Observer
public class ConcreteObserver : IObserver
{
    private Subject subject;

    public ConcreteObserver(Subject subject)
    {
        this.subject = subject;
        this.subject.Attach(this);
    }

    public void Update()
    {
        Console.WriteLine("State changed to: " + subject.State);
    }
}
