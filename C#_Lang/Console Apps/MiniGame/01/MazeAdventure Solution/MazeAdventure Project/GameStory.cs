namespace MazeAdventure_Project
{
    public class GameStory
    {
        public void CharacterStatus(Entity character, GameEntities gameEntities)
        {
            Console.WriteLine($"::Current Status::{Environment.NewLine}");
            Console.WriteLine($"{gameEntities.DisplayEntity(character)}{Environment.NewLine}");
        }
        public void GameIntro()
        {
            Console.WriteLine($"Welcome to the Maze Adventurer!{Environment.NewLine}" +
                              $"Discover the mystery of the maze,{Environment.NewLine}" +
                              $"recover hidden treasure and {Environment.NewLine}" +
                              $"defeat monster.{Environment.NewLine}" +
                              $"Now go beyond the maze with your {Environment.NewLine}" +
                              $"strength and knowledge. Defeat the maze king.{Environment.NewLine}{Environment.NewLine}");

            Console.WriteLine("Now identify yourself adventurer");
            Console.Write("[Name]>> ");
        }

        public void CharacterIdentification(Entity character, GameEntities gameEntities)
        {
            Console.WriteLine($"Congratulation {character.Name} and GoodLuck");
            CharacterStatus(character, gameEntities);
        }

        public void GuardianBless(Entity character, GameEntities gameEntities)
        {
            Console.WriteLine("The Maze-Guardian will grant you a blessing for your journey...");
            Thread.Sleep(500);
            Console.WriteLine(">");
            Thread.Sleep(500);
            Console.WriteLine(">>");
            Thread.Sleep(500);
            Console.WriteLine(">>>");
            Thread.Sleep(500);
            Console.WriteLine("[Aquired]");
            Console.WriteLine($"[Adventurer Blessing]{Environment.NewLine}");
            Thread.Sleep(500);
            Console.WriteLine("[Level Up]");
        }

        public void EnterMaze()
        {
            Console.WriteLine("You are now entering to the Maze.");
            Thread.Sleep(500);
            Console.WriteLine(">");
            Thread.Sleep(500);
            Console.WriteLine(">>");
            Thread.Sleep(500);
            Console.WriteLine(">>>");
            Thread.Sleep(500);
            Console.WriteLine(">>>>");
            Thread.Sleep(500);
            Console.WriteLine(">>>>>");
            Thread.Sleep(500);
            Console.WriteLine("[GoodLuck]");
        }
    }
}
