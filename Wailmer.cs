using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Wailmer : Pokemon
    {
        public override string Name => "Wailmer";
        public override string Type => "Water";
        public override int HP => 130;
        public override int Attack => 70;
        public override int Defense => 35;
        public override int Speed => 60;
    }
}
