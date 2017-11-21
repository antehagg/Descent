using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Abilities;
using DataLib.Items.ItemData;

namespace DataLib.Items
{
    public class Item
    {
        public int Id;
        public string Name;
        public EquipType EquipType;
        public int Cost;
        public List<ItemTrait> Traits;
        public List<Ability> Abilities;
    }
}
