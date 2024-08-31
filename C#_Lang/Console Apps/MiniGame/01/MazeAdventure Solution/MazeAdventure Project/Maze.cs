namespace MazeAdventure_Project
{
    public class Maze
    {
        public void MazeEntrance(GameEntities gameEntities, GameStory gameStory, LevelUp levelUp)
        {
            while (true)
            {
                gameStory.GameIntro();
                string name = Console.ReadLine()!;
                Console.Clear();

                Entity character = gameEntities.Character(name);
                Entity slime = gameEntities.Slime();
                Entity guardian = gameEntities.MazeGuardian();

                gameStory.CharacterIdentification(character, gameEntities);
                Console.Clear();

                gameStory.GuardianBless(character, gameEntities);
                levelUp.LevelIncrease(character, guardian, 0);
                gameStory.CharacterStatus(character, gameEntities);
                Thread.Sleep(2000);
                Console.Clear();

                gameStory.EnterMaze();

                Console.Write($"{Environment.NewLine}Proceed [y/n]: ");
                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.Y)
                {
                    continue;
                }
                else if (consoleKey == ConsoleKey.N)
                {
                    Environment.Exit(0);
                } else
                {

                }
            }
        }
    }
}
