using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.Characters.HeroData
{
    public class Archetype
    {
        public int Id;
        public ArchetypeName Type;
    }

    public enum ArchetypeName { Warrior, Healer, Scout, Mage }
}
