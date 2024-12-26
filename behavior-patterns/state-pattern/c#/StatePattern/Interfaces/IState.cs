namespace StatePattern.interfaces
{
    // State interface
    public interface IState
    {
        void Handle(Context context);
    }
}