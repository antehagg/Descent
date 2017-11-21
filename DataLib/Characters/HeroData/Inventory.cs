using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Items;

namespace DataLib.Characters.HeroData
{
    public class Inventory
    {
        public int Gold;
        public List<Item> Items;
        public EquipedItems EquipedItems;
    }
}
