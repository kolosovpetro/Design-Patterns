using DesignPatterns.State.Interfaces;

namespace DesignPatterns.State.States
{
    public class IceState : IState
    {
        public string Description => "Water is in Ice state";

        public void Handle(IContext context)
        {
            context.State = new LiquidState();
        }
    }
}