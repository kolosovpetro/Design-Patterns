using System.Collections;

namespace DesignPatterns.Iterator.Implementation
{
    public class Iterator : IEnumerator
    {
        private readonly int[] _collection;
        private int _index = -1;

        public Iterator(int[] collection)
        {
            _collection = collection;
        }

        public bool MoveNext()
        {
            _index++;
            return _index < _collection.Length;
        }

        public void Reset() => _index = -1;

        public object Current => GetCurrent();

        private object GetCurrent() => _collection[_index];
    }
}