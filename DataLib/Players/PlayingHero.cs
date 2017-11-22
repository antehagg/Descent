using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Characters;
using DataLib.Characters.HeroData;

namespace DataLib.Players
{
    public class PlayingHero
    {
        public Hero Hero { get; set; }
        public Inventory Inventory { get; set; }
    }
}
