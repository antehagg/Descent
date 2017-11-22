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
        public int Id { get; set; }
        public int Health { get; set; }
        public int Speed { get; set; }
        public int Stamina { get; set; }
        public Defense Defense { get; set; }
    }
}

