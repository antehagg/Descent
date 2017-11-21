using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Dices;
using DataLib.Items.ItemData;

namespace DataLib.Items
{
    public class Weapon : Item
    {
        public AttackType AttackType;
        public List<Dice> AttackDice;
    }
}
