using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Characters.HeroData.CharacteristicSpecifiks;

namespace DataLib.Characters.HeroData
{
    public class Characteristics
    {
        public Health Health;
        public Characteristic Speed;
        public Stamina Stamina;
        public Defense Defense;
    }

    public class Characteristic
    {
        public int Id;
        public string Name;
        public int Value;
    }
}

