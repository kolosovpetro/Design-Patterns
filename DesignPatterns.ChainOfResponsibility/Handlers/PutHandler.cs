using System;
using DesignPatterns.ChainOfResponsibility.Interfaces;

namespace DesignPatterns.ChainOfResponsibility.Handlers
{
    public class PutHandler : IHandler
    {
        public string Response { get; private set; } = "No any requests passed through";
        public IHandler Next { get; set; }

        public void Handle(IRequest request)
        {
            if (request.RequestType == "PUT")
            {
                request.IsHandled = true;
                Response = $"Put Handler: Request with {request.RequestId} is handled";
                Console.WriteLine(Response);
            }

            else if (Next != null)
            {
                Response = $"Put Handler: Request with {request.RequestId} is passed to next handler";
                Console.WriteLine(Response);
                Next.Handle(request);
            }

            else
            {
                Response = $"Put Handler: Request with {request.RequestId} is not handled";
                Console.WriteLine(Response);
            }
        }
    }
}