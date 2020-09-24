namespace DesignPatterns.Prototype.Interfaces
{
    public interface IEntity : ICloneable<IEntity>
    {
        string Name { get; set; }
        string Age { get; set; }
        int Id { get; set; }
    }
}