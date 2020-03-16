using System.Collections.Generic;
using System.Linq;

namespace DicePool
{
    public class Die
    {
        public string Name { get; }

        public List<string> facets { get; }

        public Die(int sides, string name = "")
        {
            if (name == "")
            {
                Name = sides + "sided";
            }
            else
            {
                Name = name;
            }
            
            facets = Enumerable.Range(1, sides).Select(x => x.ToString()).ToList();
        }
    }
}