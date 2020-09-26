using DesignPatterns.Decorator.BaseFunctionality;

namespace DesignPatterns.Decorator.Decorators
{
    public class BaseDecorator : IComponent
    {
        private IComponent Component { get; }

        // aggregation in constructor
        protected BaseDecorator(IComponent component)
        {
            Component = component;
        }

        // virtual method to be overriden in child-decorators
        public virtual string WriteColor()
        {
            return Component.WriteColor();
        }
    }
}
