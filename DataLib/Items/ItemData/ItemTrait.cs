using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.Items.ItemData
{
    public class ItemTrait
    {
        public int Id;
        public ItemTraitType Type;
    }

    public enum ItemTraitType { Bow, Exotic, Ring, Hammer }
}
