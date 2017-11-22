using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Abilities;
using DataLib.Characters.HeroData;
using DataLib.Items.ItemData;

namespace DataLib.Items
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EquipType EquipType { get; set; }
        public int Cost { get; set; }
        public List<ItemTrait> Traits { get; set; }
        public List<Ability> Abilities { get; set; }
        public Inventory Inventory { get; set; }
    }
}
