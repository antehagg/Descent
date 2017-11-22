using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.Dices.DiceData
{
    public class DiceSide
    {
        public int Id { get; set; }
        public int Miss { get; set; }
        public int Hearth { get; set; }
        public int Surge { get; set; }
        public int Value { get; set; }
        public int Shield { get; set; }

        public void Add(DiceSide ds)
        {
            Miss += ds.Miss;
            Hearth += ds.Hearth;
            Surge += ds.Surge;
            Value += ds.Value;
            Shield += ds.Shield;
        }

        public override string ToString()
        {
            return Miss + " Miss" + Hearth + " Hearth" + Surge + " Surge" + Value + " Value" + Shield + " Shield";
        }
    }
}
