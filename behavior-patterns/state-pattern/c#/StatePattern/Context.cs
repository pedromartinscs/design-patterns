using StatePattern.interfaces;

namespace StatePattern
{
    // Context class
    public class Context
    {
        private IState _state = null!;

        public IState State
        {
            get { return _state; }
            set
            {
                _state = value;
                Console.WriteLine($"State changed to {value.GetType().Name}");
            }
        }

        public Context(IState state)
        {
            State = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }

        public void ChangeState(IState state)
        {
            State = state;
        }
    }
}