 namespace Endless_Dungeon_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCompleted = false;
            GameEntity gameEntity = new GameEntity();
            GameStory gameStory = new GameStory();

            while (!isCompleted)
            {
                Console.WriteLine($"{Environment.NewLine}\t********************************");
                Console.WriteLine($"\t\tEndless Dungeon");
                Console.WriteLine($"\t\t [Mini Game]");
                Console.WriteLine($"\t********************************{Environment.NewLine}");

                Console.WriteLine("\tPress [y] - Start the game. ");
                Console.WriteLine("\tPress [x] - Exit the game. ");
                Console.WriteLine($"{Environment.NewLine}\t********************************");
                Console.Write($"\t>> ");
                
                ConsoleKey consoleKey = Console.ReadKey().Key;

                switch (consoleKey)
                {
                    case ConsoleKey.Y:
                        StartGame(gameEntity, gameStory);
                        break;
                    case ConsoleKey.X:
                        isCompleted = true;
                        break;
                    default:
                        Console.Error.WriteLine(" - [Error] press 'y' to exit...");
                        break;
                }
            }
        }

        private static void StartGame(GameEntity gameEntity, GameStory gameStory)
        {
            while (true)
            {
                gameStory.GameIntro();

                Entity adventurer = gameEntity.Character();

                gameStory.FirstFloor(adventurer, gameEntity);

                Console.WriteLine($"{Environment.NewLine}\tPress [y] - Begin. ");
                Console.WriteLine($"\tPress [x] - Return. ");
                Console.Write("\t>> ");
                ConsoleKey consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.X)
                {
                    Console.Clear();
                    break;
                }
                else if (consoleKey == ConsoleKey.Y)
                {
                    GameBattle gameBattle = new GameBattle();

                    gameBattle.Roaming(adventurer, gameEntity, gameStory);
                }
            }
        }
    }
}
