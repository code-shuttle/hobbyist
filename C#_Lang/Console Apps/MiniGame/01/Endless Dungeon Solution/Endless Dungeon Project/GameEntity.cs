namespace Endless_Dungeon_Project
{
    public class GameEntity
    {
        public Entity Character()
        {
            string name = "Endless";
            Entity entity = new Entity();
            
            entity.Name = name;
            entity.Health = 100;
            entity.Attack = 25;

            return entity;
        }

        public Entity Slime()
        {
            string name = "Slime";
            Entity entity = new Entity();

            entity.Name = name;
            entity.Health = 50;
            entity.Attack = 15;

            return entity;
        }

        public string DisplayEntity(Entity entity)
        {
            return $"\tName   : {entity.Name}{Environment.NewLine}" +
                   $"\tHealth : {entity.Health}{Environment.NewLine}" +
                   $"\tAttack : {entity.Attack}{Environment.NewLine}";
        }
    }
}
