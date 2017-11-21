using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Dices.DiceData;

namespace DataLib.Dices
{
    public class Dice
    {
        public int Id;
        public string Color;
        public DiceType DiceType;

        public List<DiceSide> Sides;

        public int GetSides()
        {
            return Sides.Count;
        }
    }
}
