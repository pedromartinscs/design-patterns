using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Same client code can work with different subclasses:");

            AbstractClass concreteClass1 = new ConcreteClass1();
            concreteClass1.TemplateMethod();

            Console.WriteLine();

            Console.WriteLine("Same client code can work with different subclasses:");
            AbstractClass concreteClass2 = new ConcreteClass2();
            concreteClass2.TemplateMethod();
        }
    }
}