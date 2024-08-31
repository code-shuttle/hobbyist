namespace Endless_Dungeon_Project
{
    public interface IEntity
    {
        string Name { get; set; }
        int Health { get; set; }
        int Attack { get; set; }
    }
    public class Entity : IEntity
    {
        public string Name { get; set; } = string.Empty;

        public int Health { get; set; }
        public int Attack { get; set; }
    }
}
