namespace DesignPatterns.ChainOfResponsibility.Interfaces
{
    public interface IChain
    {
        IHandler First { get; }
        void AddNext(IHandler handler);
        void Handle(IRequest request);
    }
}