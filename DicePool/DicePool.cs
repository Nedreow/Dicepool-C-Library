using System.Collections.Generic;

namespace DicePool
{
    public class DicePool
    {
        public string Name { get; }

        public List<Die> Dice { get; }
        
        public List<Dictionary<string, string>> Results { get; }

        public DicePool(string name)
        {
            Name = name;
            Dice = new List<Die>();
        }

        public List<Die> AddDie(int sides, string name = "", int amount = 1)
        {
            for (int i = 0; i < amount; i++)
            {
                Dice.Add(new Die(sides));
            }
            return Dice;
        }

        public Dictionary<string, string> GetLatestResult()
        {
            return Results[-1];
        }
    }
}