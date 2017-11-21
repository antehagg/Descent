using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.Characters.HeroData
{
    public class Attributes
    {
        public Attribute Might;
        public Attribute Knowledge;
        public Attribute Willpower;
        public Attribute Awareness;
    }

    public class Attribute
    {
        public int Id;
        public string Name;
        public int Value;
    }
}
