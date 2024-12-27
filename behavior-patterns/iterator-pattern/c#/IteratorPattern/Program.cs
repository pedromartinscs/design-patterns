using IteratorPattern.Interfaces;
using IteratorPattern.Model;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SomeCollection items = new SomeCollection();
            items[0] = "Item A";
            items[1] = "Item B";
            items[2] = "Item C";
            items[3] = "Item D";

            IIterator iterator = items.CreateIterator();

            Console.WriteLine("Iterating over collection:");

            while (iterator.HasNext())
            {
                object item = iterator.Next();
                Console.WriteLine(item);
            }
        }
    }
}