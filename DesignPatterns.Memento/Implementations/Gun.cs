using System;
using DesignPatterns.Memento.Interfaces;

namespace DesignPatterns.Memento.Implementations
{
    public class Gun : IGun
    {
        private Gun _currentState;
        
        public int AmmoCount { get; private set; }

        public Gun(int ammoCount)
        {
            AmmoCount = ammoCount;
        }

        public void Shot()
        {
            if (AmmoCount == 0)
                throw new InvalidOperationException("Gun is empty. Reload.");

            AmmoCount -= 1;
        }

        public void SaveState()
        {
            _currentState = new Gun(AmmoCount);
        }

        public void LoadState()
        {
            AmmoCount = _currentState.AmmoCount;
        }
    }
}