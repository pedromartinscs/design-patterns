namespace AdapterPattern.Interfaces
{
    // The Target class defines the domain-specific interface used by the client code.
    public interface ITarget
    {
        string GetRequest();
    }
}