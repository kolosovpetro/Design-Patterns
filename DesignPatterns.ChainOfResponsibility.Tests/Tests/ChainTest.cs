using DesignPatterns.ChainOfResponsibility.Handlers;
using DesignPatterns.ChainOfResponsibility.Interfaces;
using DesignPatterns.ChainOfResponsibility.Requests;
using FluentAssertions;
using NUnit.Framework;

namespace DesignPatterns.ChainOfResponsibility.Tests.Tests
{
    [TestFixture]
    public class ChainTest
    {
        [Test]
        public void Chain_Test()
        {
            IChain chain = new Chain.Chain();
            IHandler getHandler = new GetHandler();
            IHandler putHandler = new PutHandler();
            IHandler postHandler = new PostHandler();
            IRequest request = new PutRequest(3);
            
            chain.AddNext(putHandler);
            chain.AddNext(getHandler);
            chain.AddNext(postHandler);
            
            chain.Handle(request);
            request.IsHandled.Should().BeTrue();
            getHandler.Response.Should().Be("Get Handler: Request with 3 is passed to next handler");
            postHandler.Response.Should().Be("Post Handler: Request with 3 is passed to next handler");
            putHandler.Response.Should().Be("Put Handler: Request with 3 is handled");
        }
    }
}