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
Inside this file it will have the interface called "IEnity" and a class called "Enity".

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
## GameEntity.cs
## GameStory.cs
## GameBattle.cs
## Program.cs