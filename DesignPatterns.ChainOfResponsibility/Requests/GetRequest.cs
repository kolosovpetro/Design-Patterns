using DesignPatterns.ChainOfResponsibility.Interfaces;

namespace DesignPatterns.ChainOfResponsibility.Requests
{
    public class GetRequest : IRequest
    {
        public int RequestId { get; }
        public bool IsHandled { get; set; }
        public string RequestType => "GET";

        public GetRequest(int requestId)
        {
            RequestId = requestId;
        }
    }
}