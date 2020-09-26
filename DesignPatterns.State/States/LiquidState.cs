using DesignPatterns.State.Interfaces;

namespace DesignPatterns.State.States
{
    public class LiquidState : IState
    {
        public string Description => "Water is in Liquid State";
        public void Handle(IContext context)
        {
            context.State = new SteamState();
        }
    }
}