using DesignPatterns.State.Interfaces;

namespace DesignPatterns.State.States
{
    public class SteamState : IState
    {
        public string Description => "Water is in Steam State";
        public void Handle(IContext context)
        {
            context.State = new IceState();
        }
    }
}