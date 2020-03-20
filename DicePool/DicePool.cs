using System.Collections.Generic;

namespace DicePool
{
    public class DicePool
    {
        public string Name { get; }

        public List<Die> Dice { get; }
        
        public List<RollResult> Results { get; }

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

        public RollResult RollPool()
        {
            var results = new RollResult();
            foreach (var die in Dice)
            {
                results.AddResult(die.Name, die.Roll());
            }
            Results.Add(results);
            return results;
        }

        public RollResult GetLatestResult()
        {
            return Results[-1];
        }
    }
}