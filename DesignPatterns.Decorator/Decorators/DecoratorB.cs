﻿using DesignPatterns.Decorator.BaseFunctionality;

namespace DesignPatterns.Decorator.Decorators
{
    public class DecoratorB : BaseDecorator
    {
        public DecoratorB(IComponent component) : base(component)
        {

        }

        // override of parent method
        public override string WriteColor()
        {
            return base.WriteColor() + WriteBlack();
        }

        // additional functionality
        private static string WriteBlack()
        {
            return "Black ";
        }
    }
}
