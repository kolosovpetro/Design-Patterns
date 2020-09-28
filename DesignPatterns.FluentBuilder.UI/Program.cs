using System;
using DesignPatterns.FluentBuilder.Implementations;
using DesignPatterns.FluentBuilder.Interfaces;

namespace DesignPatterns.FluentBuilder.UI
{
    public static class Program
    {
        public static void Main()
        {
            IFluentBuilder builder = new Implementations.FluentBuilder();
            IDirector director = new Director(builder);
            director.Construct();
            var car = builder.ReturnCar();
            Console.WriteLine(car);
        }
    }
}