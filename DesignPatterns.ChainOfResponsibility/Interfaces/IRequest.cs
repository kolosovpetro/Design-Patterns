namespace DesignPatterns.ChainOfResponsibility.Interfaces
{
    public interface IRequest
    {
        int RequestId { get; }
        bool IsHandled { get; set; }
        string RequestType { get; }
    }
}