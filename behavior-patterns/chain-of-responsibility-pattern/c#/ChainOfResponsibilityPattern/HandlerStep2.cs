namespace ChainOfResponsibilityPattern
{
    // Concrete Handler 2
    class HandlerStep2 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 10 && request < 20)
            {
                Console.WriteLine($"{this.GetType().Name} handled request {request}");
            }
            else if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}