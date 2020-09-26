using DesignPatterns.ChainOfResponsibility.Interfaces;

namespace DesignPatterns.ChainOfResponsibility.Requests
{
    public class PutRequest : IRequest
    {
        public int RequestId { get; }
        public bool IsHandled { get; set; }
        public string RequestType => "PUT";

        public PutRequest(int requestId)
        {
            RequestId = requestId;
        }
    }
}