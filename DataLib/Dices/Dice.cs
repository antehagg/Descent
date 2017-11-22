using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Characters;
using DataLib.Characters.HeroData.CharacteristicSpecifiks;
using DataLib.Dices.DiceData;
using DataLib.Items;

namespace DataLib.Dices
{
    public class Dice
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public DiceType DiceType { get; set; }

        public List<DiceSide> Sides { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Defense> Defense { get; set; }
        public List<Monster> Monster { get; set; }

        public int GetSides()
        {
            return Sides.Count;
        }
    }
}
