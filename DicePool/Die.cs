using System.Collections.Generic;
using System.Linq;

namespace DicePool
{
    public class Die
    {
        public string Name { get; }

        public List<string> Facets { get; }
        
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
            
            Facets = Enumerable.Range(1, sides).Select(x => x.ToString()).ToList();
        }

        public Die(List<string> facets, string name = "")
        {
            Name = name;
            Facets = facets;
        }

        public string Roll()
        {
            return Facets[0];
        }
    }
}