using System;
using System.Collections.Generic;

// Client
class Program
{
    static void Main(string[] args)
    {
        List<IElement> elements = new List<IElement>
        {
            new ElementA(),
            new ElementB()
        };

        IVisitor visitor = new ConcreteVisitor();

        foreach (var element in elements)
        {
            element.Accept(visitor);
        }
    }
}