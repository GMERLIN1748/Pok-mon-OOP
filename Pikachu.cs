using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Pikachu : Pokemon
    {
        public override string Name => "Pikachu";
        public override string Type => "Electric";
        public override int HP => 35;
        public override int Attack => 55;
        public override int Defense => 40;
        public override int Speed => 90;
    }
}
