using DesignPatterns.State.Interfaces;
using DesignPatterns.State.States;

namespace DesignPatterns.State.Entities
{
    public class WaterEntity : IContext
    {
        public IState State { get; set; } = new IceState();
        public string StateDescription => State.Description;
        public void ChangeState() => State.Handle(this);
    }
}