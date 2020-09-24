using DesignPatterns.Prototype.Interfaces;

namespace DesignPatterns.Prototype.Concrete
{
    public class Entity : IEntity
    {
        public string Name { get; set; }
        public string Age { get; set; }
        public int Id { get; set; }

        public Entity(string name, string age, int id)
        {
            Name = name;
            Age = age;
            Id = id;
        }

        public IEntity Clone() => new Entity(Name, Age, Id);
    }
}