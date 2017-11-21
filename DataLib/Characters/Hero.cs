using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Characters.HeroData;

namespace DataLib.Characters
{
    public class Hero : ICharacter
    {
        public int Id;
        public string Name;
        public Archetype Archetype;
        public Characteristics Characteristics;
        public Attributes Attributes;
        public Inventory Inventory;
    }
}
