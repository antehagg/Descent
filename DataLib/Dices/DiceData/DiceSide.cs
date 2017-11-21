using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.Dices.DiceData
{
    public class DiceSide
    {
        public int Miss;
        public int Hearth;
        public int Surge;
        public int Value;
        public int Shield;

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
