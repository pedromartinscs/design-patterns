
// Subject
public class Subject
{
    private List<IObserver> observers = new List<IObserver>();
    private int state;

    public int State
    {
        get { return state; }
        set
        {
            state = value;
            NotifyAllObservers();
        }
    }

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void NotifyAllObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update();
        }
    }
}
