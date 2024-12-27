namespace IteratorPattern.Interfaces
{
    // Iterator interface
    public interface IIterator
    {
        bool HasNext();
        object Next();
    }
}