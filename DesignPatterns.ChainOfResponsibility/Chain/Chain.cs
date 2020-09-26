using DesignPatterns.ChainOfResponsibility.Interfaces;

namespace DesignPatterns.ChainOfResponsibility.Chain
{
    public class Chain : IChain
    {
        public IHandler First { get; private set; }

        public void AddNext(IHandler handler)
        {
            if (First == null)
            {
                First = handler;
                return;
            }

            var first = First;
            First = handler;
            First.Next = first;
        }

        public void Handle(IRequest request)
        {
            First.Handle(request);
        }
    }
}