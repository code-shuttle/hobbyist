# Endless Dungeon
Simple Text-Base Game. This mini-game will let you roam around inside the dungeon and kill slime monster.

### Overview
Building this simple text-base game utilizing the Object-oriented programming language using the C# language. It have a simple interface for the main character and the slime monster. Straigth forward game logic.

### Table of Contents
- [Entity.cs](#entitycs)
- [GameEntity.cs](#gameentitycs)
- [GameStory.cs](#gamestorycs)
- [GameBattle.cs](#gamebattlecs)
- [Program.cs](#programcs)


## Entity.cs
Inside this file it will have the interface called "IEntity" and a class called "Entity".

```
    public interface IEntity
    {
        string Name { get; set; }
        int Health { get; set; }
        int Attack { get; set; }
    }
    public class Entity : IEntity
    {
        public string Name { get; set; } = string.Empty;

        public int Health { get; set; }
        public int Attack { get; set; }
    }
```
The Entity class will have an interface called IEntity.

## GameEntity.cs
In this class the creation or instantiation of the game entity which the main character "Endless" and the "Slime" monster.

This is for the main character. Named "Endless".
```
        public Entity Character()
        {
            string name = "Endless";
            Entity entity = new Entity();
            
            entity.Name = name;
            entity.Health = 100;
            entity.Attack = 25;

            return entity;
        }
```

This is for the monster. Named "Slime".
```
        public Entity Slime()
        {
            string name = "Slime";
            Entity entity = new Entity();

            entity.Name = name;
            entity.Health = 50;
            entity.Attack = 15;

            return entity;
        }
```

A display method called DisplayEntity().
```
        public string DisplayEntity(Entity entity)
        {
            return $"\tName   : {entity.Name}{Environment.NewLine}" +
                   $"\tHealth : {entity.Health}{Environment.NewLine}" +
                   $"\tAttack : {entity.Attack}{Environment.NewLine}";
        }
```

## GameStory.cs
In this class will have the game story wrap inside its own method.

This will display character status. It will need the Entity and GameEntity object to display the character or entity status.
```
        public void CharacterStatus(Entity entity, GameEntity gameEntity)
        {
            Console.WriteLine(gameEntity.DisplayEntity(entity));
        }
```

Text game introduction method.
```
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
```

Text introduction to first floor of dungeon method. 
```
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
```
It will need Entity and GameEntity as a parameter.

Loading area for roaming the dungeon.
```
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
```

Loading display method.
```
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
```
It will have label and timer for loading information.

Loading display for finishing the battle method.
```
        public void FinishedBattle(int timer)
        {
            Thread.Sleep(timer);
            Console.WriteLine("\t[Congratulation you successfully defeated the enemy....]");
        }
```
It will have a timer as a parameter.

Text battle scene or display method.
```
        public void BattleScene(Entity attackerEntity, Entity defenderEntity, GameEntity gameEntity, GameStory gameStory)
        {
            defenderEntity.Health = defenderEntity.Health - attackerEntity.Attack;
            gameStory.Loading("Fight", 500);
            Console.WriteLine($"\t>> [{attackerEntity.Name}] - inflict [{attackerEntity.Attack}] damage attack to [{defenderEntity.Name}] ");
            Thread.Sleep(1000);
            gameStory.CharacterStatus(attackerEntity, gameEntity);
            gameStory.CharacterStatus(defenderEntity, gameEntity);
        }
```
It will need two Entity for attackerEntity and defenderEntity, a GameEntity, and GameStory.

## GameBattle.cs
For this class will hold the game battle.

This method is the roaming action.
```
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
```
It will instantiate the slime monster. Using the conditional statement to proceed or decline the action.

The battle method.
```
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
```
Utilizing the control-flow statement to have an infinite slime monster battle. Use the GameStory methods to display the battle scene and other display needed.

## Program.cs
In this file is the entry point of the program.

In here we have the Main function which is the entry point of the program. It is also the main screen or display lives. Using the selection-control mechanism for the selection to select whether to start game or exit game.
```
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
```
If the selection is true for start game. The StartGame function kicks in.

> [!NOTE]
> This simple project is not complete or production ready.
> This project is my hobby for self and skill improvement.
> Or discovering new things.
> Feel try to ask question about how I build it.
