using System.Drawing;

namespace Endless_Dungeon_Project
{
    public class GameStory
    {
        public void CharacterStatus(Entity entity, GameEntity gameEntity)
        {
            Console.WriteLine(gameEntity.DisplayEntity(entity));
        }
        public void GameIntro()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t..............................................");
            //Thread.Sleep(1500);
            Console.WriteLine("\tEndless Dungeon is a true endless battle.");
            //Thread.Sleep(1500);
            Console.WriteLine("\tIt began ten thousand years ago when the");
            //Thread.Sleep(1500);
            Console.WriteLine("\tfirst dungeon appears. Everything was changed.");
            //Thread.Sleep(1500);
            Console.WriteLine("\tAnd so the journey began....");
            //Thread.Sleep(1500);
            Console.WriteLine("\t..............................................");         
            //Thread.Sleep(1500);
            Console.Clear();
        }

        public void FirstFloor(Entity entity, GameEntity gameEntity)
        {
            Console.WriteLine($"{Environment.NewLine}\t..............................................");
            Console.WriteLine("\tFirst floor of endless dungeon.");
            //Thread.Sleep(1500);
            Console.WriteLine($"\tAdventurer check your status at all times.{Environment.NewLine}");
            //Thread.Sleep(1500);
            Console.WriteLine("\tStatus");
            CharacterStatus(entity, gameEntity);
            //Thread.Sleep(1500);
            Console.WriteLine($"{Environment.NewLine}\tGoodluck....");
            //Thread.Sleep(1500);
        }

        public void DungeonRoaming()
        {
            Console.WriteLine($"{Environment.NewLine}\t..............................................");
            Console.WriteLine($"\t[Dungeon Roaming....]");
            Thread.Sleep(500);
            Console.Write("\t>");
            Thread.Sleep(500);
            Console.Write(">>");
            Thread.Sleep(500);
            Console.Write(">>>>>");
            Thread.Sleep(500);
            Console.Write(">>>>>>>");
            Thread.Sleep(500);
            Console.Write(">>>>>>>>>");
            Thread.Sleep(500);
            Console.Write(">>>>>>>>>>");
            Thread.Sleep(500);
            Console.Write($">>>>>>>>>>>>{Environment.NewLine}");
        }

        public void Loading(string label, int timer)
        {
            Console.Write($"{Environment.NewLine}\t[{label}]");
            Thread.Sleep(timer);
            Console.Write("..........");
            Thread.Sleep(timer);
            Console.Write("..........");
            Thread.Sleep(timer);
            Console.Write("..........");
            Thread.Sleep(timer);
            Console.Write($"..........{Environment.NewLine}{Environment.NewLine}");
        }

        public void FinishedBattle(int timer)
        {
            Thread.Sleep(timer);
            Console.WriteLine("\t[Congratulation you successfully defeated the enemy....]");
        }

        public void BattleScene(Entity attackerEntity, Entity defenderEntity, GameEntity gameEntity, GameStory gameStory)
        {
            defenderEntity.Health = defenderEntity.Health - attackerEntity.Attack;
            gameStory.Loading("Fight", 500);
            Console.WriteLine($"\t>> [{attackerEntity.Name}] - inflict [{attackerEntity.Attack}] damage attack to [{defenderEntity.Name}] ");
            Thread.Sleep(1000);
            gameStory.CharacterStatus(attackerEntity, gameEntity);
            gameStory.CharacterStatus(defenderEntity, gameEntity);
        }
    }
}
