using System.Collections.Generic;

namespace DicePool
{
    public struct RollResult
    {
        public Dictionary<string, string> Results { get; }

        public void AddResult(string dieName, string result)
        {
            Results.Add(dieName, result);
        }

        public Dictionary<string, int> GetIntResults()
        {
            var intResults = new Dictionary<string, int>();

            foreach (var result in Results)
            {
                if (int.TryParse(result.Value, out var intValue))
                {
                    intResults.Add(result.Key, intValue);
                }
            }

            return intResults;
        }
    }
}