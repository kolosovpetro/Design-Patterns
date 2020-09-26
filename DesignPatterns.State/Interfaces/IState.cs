namespace DesignPatterns.State.Interfaces
{
    public interface IState
    {
        string Description { get; }
        void Handle(IContext context);
    }
}