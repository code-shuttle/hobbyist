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
## Program.cs