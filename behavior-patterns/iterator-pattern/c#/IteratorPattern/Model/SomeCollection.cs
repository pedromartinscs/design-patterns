using System.Collections;
using IteratorPattern.Implementations;
using IteratorPattern.Interfaces;

namespace IteratorPattern.Model
{
    // Model with some random collection
    public class SomeCollection
    {
        private ArrayList _items = new ArrayList();

        public IIterator CreateIterator()
        {
            return new SomeCollectionIterator(this);
        }

        public int Count
        {
            get { return _items.Count; }
        }

        public object this[int index]
        {
            get { return _items[index]!; }
            set { _items.Insert(index, value); }
        }
    }
}