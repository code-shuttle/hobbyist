namespace MazeAdventure_Project
{
    public interface IEntity
    {
        string Name { get; set; }
        int Level { get; set; }
        int Exp { get; set; }
        int Health { get; set; }
        int Attack { get; set; }
    }
    public class Entity : IEntity
    {
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        public int Exp { get; set; }
        public int Health { get; set; }
        public int Attack { get; set; }
    }
}
