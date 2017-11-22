using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Dices;

namespace DataLib.Characters.HeroData.CharacteristicSpecifiks
{
    public class Defense
    {
        public int Id { get; set; }
        public List<Dice> Dices { get; set; }
    }
}
