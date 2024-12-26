class Originator
{
    private string _state = null!;

    public void SetState(string state)
    {
        Console.WriteLine("Originator: Setting state to " + state);
        _state = state;
    }

    public string GetState()
    {
        return _state;
    }

    public Memento SaveStateToMemento()
    {
        Console.WriteLine("Originator: Saving state to Memento.");
        return new Memento(_state);
    }

    public void GetStateFromMemento(Memento memento)
    {
        _state = memento.GetState();
        Console.WriteLine("Originator: State after restoring from Memento: " + _state);
    }
}
