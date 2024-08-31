namespace MazeAdventure_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                GameEntities gameEntities = new GameEntities();
                GameStory gameStory = new GameStory();
                LevelUp levelUp = new LevelUp();

                Maze maze = new Maze();
                
                maze.MazeEntrance(gameEntities, gameStory, levelUp);
            }
        }
    }
}
