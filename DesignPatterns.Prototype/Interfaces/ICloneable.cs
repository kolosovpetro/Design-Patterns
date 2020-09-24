namespace DesignPatterns.Prototype.Interfaces
{
    public interface ICloneable<out T>
    {
        T Clone();
    }
}