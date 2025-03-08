using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    // inheritance from
    public class Tentacool : Pokemon
    {
        private ResourceManager Resource1; // Change object to ResourceManager

        public Tentacool()
        {
            this.Name = "Tentacool";
            this.Type = PokemonType.Water;
            this.Type2 = PokemonType.Poison;
            this.HP = 40;
            this.Attack = 40;
            this.Defense = 35;
            this.SpecialAttack = 50;
            this.SpecialDefense = 100;
            this.Speed = 70;
            this.Total = 335;

            this.image = Resource1.GetObject("Tentacool") as byte[] ?? Array.Empty<byte>(); // Simplified collection initialization
        }
    }
}
