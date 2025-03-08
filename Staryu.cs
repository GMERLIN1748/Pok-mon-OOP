using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    // inheritance from
    public class Staryu : Pokemon
    {
        private ResourceManager Resource1; // Change object to ResourceManager
        public Staryu()
        {
            this.Name = "Staryu";
            this.Type = PokemonType.Water;
            this.Type2 = PokemonType.None;
            this.HP = 30;
            this.Attack = 45;
            this.Defense = 55;
            this.SpecialAttack = 70;
            this.SpecialDefense = 55;
            this.Speed = 85;
            this.Total = 340;

            this.image =
                Resource1.GetObject("Staryu") as byte[] ?? Array.Empty<byte>();
        }
    }
}
