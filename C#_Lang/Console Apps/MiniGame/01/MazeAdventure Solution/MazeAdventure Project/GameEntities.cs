namespace MazeAdventure_Project
{
    public class GameEntities
    {
        
        public Entity Character(string name)
        {
            Entity entity = new Entity();
            entity.Name = name;
            entity.Level = 0;
            entity.Exp = 0;
            entity.Health = 5;
            entity.Attack = 1;

            return entity;
        }

        public Entity MazeGuardian()
        {
            Entity entity = new Entity();
            entity.Name = "Guardian";
            entity.Exp = 10;

            return entity;
        }

        public Entity Slime()
        {
            Entity entity = new Entity();
            entity.Name = "Slime";
            entity.Level = 1;
            entity.Exp = 1;
            entity.Health = 5;
            entity.Attack = 1;

            return entity;
        }

        public Entity Wolf()
        {
            Entity entity = new Entity();
            entity.Name = "Wolf";
            entity.Level = 2;
            entity.Exp = 2;
            entity.Health = 10;
            entity.Attack = 3;

            return entity;
        }

        public Entity Goblin()
        {
            Entity entity = new Entity();
            entity.Name = "Goblin";
            entity.Level = 3;
            entity.Exp = 3;
            entity.Health = 15;
            entity.Attack = 6;

            return entity;
        }

        public string DisplayEntity(Entity entity)
        {
            return $"Character    :: {entity.Name}{Environment.NewLine}" +
                   $"Level        :: {entity.Level}{Environment.NewLine}" +
                   $"Exp          :: {entity.Exp}{Environment.NewLine}" +
                   $"Health       :: {entity.Health}{Environment.NewLine}" +
                   $"Attack Power :: {entity.Attack}{Environment.NewLine}";
        }
    }
}
