using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Characters.HeroData;

namespace DataLib.Characters
{
    public class Hero : Character
    {
        public Archetype Archetype { get; set; }
        public Attributes Attributes { get; set; }
    }
}
