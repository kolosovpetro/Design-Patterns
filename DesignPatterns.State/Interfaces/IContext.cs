namespace DesignPatterns.State.Interfaces
{
    public interface IContext
    {
        string StateDescription { get; }
        IState State { get; set; }
        void ChangeState();
    }
}