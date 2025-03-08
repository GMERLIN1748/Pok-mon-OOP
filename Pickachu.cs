using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    // inheritance from
    public class Pickachu : Pokemon
    {
        private ResourceManager Resource1; // Change object to ResourceManager
        public Pickachu()
        {
            this.Name = "Pickachu";
            this.Type = PokemonType.Electric;
            this.Type2 = PokemonType.None;
            this.HP = 35;
            this.Attack = 55;
            this.Defense = 40;
            this.SpecialAttack = 50;
            this.SpecialDefense = 50;
            this.Speed = 90;
            this.Total = 320;

            this.image =
                Resource1.GetObject("Pikachu") as byte[] ?? Array.Empty<byte>();

        }
    }
}
