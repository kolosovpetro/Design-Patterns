using DesignPatterns.ChainOfResponsibility.Handlers;
using DesignPatterns.ChainOfResponsibility.Interfaces;
using DesignPatterns.ChainOfResponsibility.Requests;

namespace DesignPatterns.ChainOfResponsibility.UI
{
    public static class Program
    {
        private static void Main()
        {
            IChain chain = new Chain.Chain();
            chain.AddNext(new PutHandler());
            chain.AddNext(new PostHandler());
            chain.AddNext(new GetHandler());
            chain.Handle(new PutRequest(3));
        }
    }
}