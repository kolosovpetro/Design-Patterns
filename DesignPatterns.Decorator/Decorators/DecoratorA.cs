﻿using DesignPatterns.Decorator.BaseFunctionality;

namespace DesignPatterns.Decorator.Decorators
{
    public class DecoratorA : BaseDecorator
    {
        public DecoratorA(IComponent component) : base(component)
        {

        }

        // overriding of existing method
        public override string WriteColor()
        {
            return base.WriteColor() + WriteRed();
        }

        // additional functionality
        private static string WriteRed()
        {
            return "Red ";
        }
    }
}
