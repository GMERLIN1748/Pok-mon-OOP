using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public enum PokemonType
    {
        Fire,
        Water,
        Grass,
        Electric,
        Psychic,
        Ice,
        Dragon,
        Dark,
        Fairy,
        None,
        Poison
    }

    public class Pokemon
    {
        public string Name;
        public int HP;
        public int Attack;
        public int Defense;
        public int SpecialAttack;
        public int SpecialDefense;
        public int Speed;
        public int Total;
        public PokemonType Type;
        public PokemonType Type2;
        public byte[] image;
        //contructor
        public Pokemon()
        {
            this.Name = string.Empty;
            this.image = Array.Empty<byte>();
        }
        //method
        public string getName()
        {
            return this.Name;
        }
        public byte[] getImage()
        {
            return this.image;
        }
    }
}
