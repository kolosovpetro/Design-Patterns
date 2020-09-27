using System;

namespace DesignPatterns.Iterator.UI
{
    public static class Program
    {
        private static void Main()
        {
            var collection = new[] {1, 2, 3, 4, 5, 6, 7};
            var iterator = new Implementation.Iterator(collection);

            Console.WriteLine("pass 1:");
            while (iterator.MoveNext())
            {
                Console.Write(iterator.Current + " ");
            }
            
            iterator.Reset();
            Console.WriteLine("pass 2 after reset");
            while (iterator.MoveNext())
            {
                Console.Write(iterator.Current + " ");
            }
        }
    }
}