using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Ditto : Pokemon
    {
        public override string Name => "Ditto";
        public override string Type => "Normal";
        public override int HP => 48;
        public override int Attack => 48;
        public override int Defense => 48;
        public override int Speed => 48;
    }
}
