namespace Endless_Dungeon_Project
{
    public class GameBattle
    {
        public void Roaming(Entity adventurer, GameEntity gameEntity, GameStory gameStory)
        {
            while (true)
            {
                Console.Clear();

                Entity slime = gameEntity.Slime();

                gameStory.DungeonRoaming();

                Console.WriteLine($"\t[{slime.Name}] detected...");

                gameEntity.DisplayEntity(slime);

                Console.WriteLine($"{Environment.NewLine}\t[y] Kill the {slime.Name}");
                Console.WriteLine($"\t[x] Return");
                Console.Write("\t>> ");
                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.Y)
                {
                    Battle(adventurer, slime, gameEntity, gameStory);
                    Thread.Sleep(1000);
                }
                else if (consoleKey == ConsoleKey.X)
                {
                    Console.Clear();
                    break;
                }
            }
        }

        public void Battle(Entity adventurer, Entity slime, GameEntity gameEntity, GameStory gameStory)
        {
            while (true)
            {
                Console.Clear();
                gameStory.Loading("Load_", 500);
                gameStory.CharacterStatus(adventurer, gameEntity);
                gameStory.CharacterStatus(slime, gameEntity);
                gameStory.Loading("Load_", 500 );
                Console.WriteLine($"\t[{adventurer.Name}] vs [{slime.Name}]{Environment.NewLine}");

                gameStory.BattleScene(adventurer, slime, gameEntity, gameStory);

                gameStory.BattleScene(slime, adventurer, gameEntity, gameStory);

                gameStory.BattleScene(adventurer, slime, gameEntity, gameStory);

                gameStory.FinishedBattle(500);

                Console.WriteLine("\t[Good Work!]");
                Thread.Sleep(500);
                gameStory.Loading("Done", 1000);

                break;
            }
        }
    }
}
