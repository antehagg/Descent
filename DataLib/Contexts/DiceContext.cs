using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Dices;
using DataLib.Dices.DiceData;

namespace DataLib.Contexts
{
    public class DiceContext : DescentContext
    {
        public DbSet<Dice> Dices { get; set; }
        public DbSet<DiceSide> DiceSides { get; set; }
        public DbSet<DiceType> DiceTypes { get; set; }
    }
}
