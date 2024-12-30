
// Concrete Mediator
public class Mediator : IMediator
{
    private List<Colleague> _colleagues = new List<Colleague>();

    public void Register(Colleague colleague)
    {
        _colleagues.Add(colleague);
    }

    public void SendMessage(string message, Colleague colleague)
    {
        foreach (var c in _colleagues)
        {
            if (c != colleague)
            {
                c.Receive(message);
            }
        }
    }
}
