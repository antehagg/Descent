using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Items;
using DataLib.Items.ItemData;

namespace DataLib.Contexts
{
    public class ItemContext : DescentContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<AttackType> AttackTypes { get; set; }
        public DbSet<EquipType> EquipTypes { get; set; }
        public DbSet<ItemTrait> ItemTraits { get; set; }
    }
}
