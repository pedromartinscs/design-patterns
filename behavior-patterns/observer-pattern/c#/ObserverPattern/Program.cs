// Program
class Program
{
    static void Main(string[] args)
    {
        Subject subject = new Subject();

        new ConcreteObserver(subject);
        new ConcreteObserver(subject);

        /* In this way, even though we have a little coupling between the Subject
         * and the ConcreteObserver, we can still add more observers without
         * changing the Subject class. We can even use both forms of communication,
         * the push and the pull, by adding a parameter to the Update method.       */

        Console.WriteLine("First state change: 15");
        subject.State = 15;

        Console.WriteLine("Second state change: 10");
        subject.State = 10;
    }
}