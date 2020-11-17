namespace DesignPatterns.Memento.Interfaces
{
    public interface IGun
    {
        int AmmoCount { get; }
        void Shot();
        void SaveState();
        void LoadState();
    }
}