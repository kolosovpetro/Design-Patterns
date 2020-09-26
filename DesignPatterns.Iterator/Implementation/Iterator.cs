using System.Collections;

namespace DesignPatterns.Iterator.Implementation
{
    public class Iterator : IEnumerator
    {
        private readonly int[] _collection;
        private int _index;

        public Iterator(int[] collection)
        {
            _collection = collection;
        }

        public bool MoveNext()
        {
            return _index < _collection.Length;
        }

        public void Reset()
        {
            _index = 0;
        }

        public object Current => GetCurrent();

        private object GetCurrent()
        {
            var currentIndex = _index;
            _index++;
            return _collection[currentIndex];
        }
    }
}