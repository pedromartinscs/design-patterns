using IteratorPattern.Interfaces;
using IteratorPattern.Model;

namespace IteratorPattern.Implementations
{
    // Concrete Iterator
    public class SomeCollectionIterator : IIterator
    {
        private SomeCollection _someCollection;
        private int _current = 0;

        public SomeCollectionIterator(SomeCollection aggregate)
        {
            _someCollection = aggregate;
        }

        public bool HasNext()
        {
            return _current < _someCollection.Count;
        }

        public object Next()
        {
            if (!HasNext())
            {
                throw new InvalidOperationException();
            }

            return _someCollection[_current++];
        }
    }
}