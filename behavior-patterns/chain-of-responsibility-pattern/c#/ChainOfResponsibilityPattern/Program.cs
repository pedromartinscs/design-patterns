using System;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility
            Handler h1 = new HandlerStep1();
            Handler h2 = new HandlerStep2();
            Handler h3 = new HandlerStep3();
            h1.SetSuccessor(h2);
            h2.SetSuccessor(h3);

            // Generate and process requests
            int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (int request in requests)
            {
                h1.HandleRequest(request);
            }
        }
    }
}