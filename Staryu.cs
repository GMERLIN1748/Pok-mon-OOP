using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Staryu : Pokemon
    {
        public override string Name => "Staryu";
        public override string Type => "Water";
        public override int HP => 30;
        public override int Attack => 45;
        public override int Defense => 55;
        public override int Speed => 85;
    }
}
