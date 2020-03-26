using System.Collections.Generic;

namespace DicePool
{
    public class RollResult
    {
        public List<KeyValuePair<string, string>> Results { get; }

        public RollResult()
        {
            Results = new List<KeyValuePair<string, string>>();
        }

        public void AddResult(string dieName, string result)
        {
            Results.Add(new KeyValuePair<string, string>(dieName, result));
        }

        public List<int> GetIntResults()
        {
            var intResults = new List<int>();

            foreach (var result in Results)
            {
                if (int.TryParse(result.Value, out var intValue))
                {
                    intResults.Add(intValue);
                }
            }
            return intResults;
        }
    }
}