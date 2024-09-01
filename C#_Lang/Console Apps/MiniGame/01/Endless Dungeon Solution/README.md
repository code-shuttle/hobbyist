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
## GameBattle.cs
## Program.cs