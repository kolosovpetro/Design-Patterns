using DesignPatterns.ChainOfResponsibility.Interfaces;

namespace DesignPatterns.ChainOfResponsibility.Requests
{
    public class PostRequest : IRequest
    {
        public int RequestId { get; }
        public bool IsHandled { get; set; }
        public string RequestType => "POST";

        public PostRequest(int requestId)
        {
            RequestId = requestId;
        }
    }
}