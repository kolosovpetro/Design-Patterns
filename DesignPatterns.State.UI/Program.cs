using System;
using DesignPatterns.State.Entities;
using DesignPatterns.State.Interfaces;

namespace DesignPatterns.State.UI
{
    public static class Program
    {
        private static void Main()
        {
            IContext water = new WaterEntity();
            Console.WriteLine(water.StateDescription);    // ice state
            water.ChangeState();
            Console.WriteLine(water.StateDescription);    // liquid state
            water.ChangeState();
            Console.WriteLine(water.StateDescription);    // steam state
            water.ChangeState();
            Console.WriteLine(water.StateDescription);    // ice state
        }
    }
}