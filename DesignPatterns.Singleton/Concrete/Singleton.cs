using System;

namespace DesignPatterns.Singleton.Concrete
{
    public class Singleton
    {
        public  DateTime TimeCreated { get; }

        public static Singleton GetInstance { get; } = new Singleton();

        static Singleton()
        {
        }

        private Singleton()
        {
            TimeCreated = DateTime.Now;
        }
    }
}