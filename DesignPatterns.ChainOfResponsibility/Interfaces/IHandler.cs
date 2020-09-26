namespace DesignPatterns.ChainOfResponsibility.Interfaces
{
    public interface IHandler
    {
        string Response { get; }
        IHandler Next { get; set; }
        void Handle(IRequest request);
    }
}