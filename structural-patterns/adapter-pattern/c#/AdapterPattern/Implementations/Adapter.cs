using AdapterPattern.Interfaces;

namespace AdapterPattern.Implementations
{
    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }
}