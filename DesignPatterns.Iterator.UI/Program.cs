using System;

namespace DesignPatterns.Iterator.UI
{
    public static class Program
    {
        private static void Main()
        {
            var collection = new[] {1, 2, 3, 4, 5, 6, 7};
            var iterator = new Implementation.Iterator(collection);
            
            while (iterator.MoveNext())
            {
                Console.Write(iterator.Current + " ");
            }
        }
    }
}