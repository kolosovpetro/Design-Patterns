using System;
using DesignPatterns.ChainOfResponsibility.Interfaces;

namespace DesignPatterns.ChainOfResponsibility.Handlers
{
    public class PostHandler : IHandler
    {
        public string Response { get; private set; } = "No any requests passed through";

        public IHandler Next { get; set; }

        public void Handle(IRequest request)
        {
            if (request.RequestType == "POST")
            {
                request.IsHandled = true;
                Response = $"Post Handler: Request with {request.RequestId} is handled";
                Console.WriteLine(Response);
            }

            else if (Next != null)
            {
                Response = $"Post Handler: Request with {request.RequestId} is passed to next handler";
                Console.WriteLine(Response);
                Next.Handle(request);
            }

            else
            {
                Response = $"Post Handler: Request with {request.RequestId} is not handled";
                Console.WriteLine(Response);
            }
        }
    }
}