namespace MazeAdventure_Project
{
    public class LevelUp
    {
        public void LevelIncrease(Entity character, Entity entity, int exp)
        {
            if (entity.Name == "Guardian")
            {
                character.Level = character.Level + 1;
                character.Exp = character.Exp + entity.Exp;
                character.Attack = character.Attack + 1;
                character.Health = character.Health + 1;
            }
        }
    }
}
