using System;
using System.Collections.Generic;
using System.Linq;

namespace DicePool
{
    public class Die
    {
        public string Name { get; }

        public List<string> Facets { get; }

        private Random random;

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
            random = new Random();
        }

        public Die(List<string> facets, string name = "")
        {
            Name = name;
            Facets = facets;
            random = new Random();
        }

        public string Roll()
        {
            return Facets[random.Next(1, Facets.Count + 1)];
        }
    }
}