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
        public int Id { get; set; }
        public int Gold { get; set; }
        public List<Item> Items { get; set; }
        public EquipedItems EquipedItems { get; set; }
    }
}
