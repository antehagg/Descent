using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Items;
using DataLib.Items.ItemData;

namespace DataLib.Characters.HeroData
{
    public class EquipedItems
    {
        public int Id { get; set; }
        public Item Armor { get; set; }
        public Item MainHand { get; set; }
        public Item OffHand { get; set; }
        public Item FirstOther { get; set; }
        public Item SecondOther { get; set; }

        public void EquipArmor(Item armor)
        {
            Armor = armor;
        }

        public bool EquipOther(Item other, out string errorMsg)
        {
            errorMsg = "";
            if (FirstOther == null)
            {
                FirstOther = other;
                return true;
            }
            if (SecondOther == null)
            {
                SecondOther = other;
                return true;
            }

            errorMsg = "Allready wearing two other items.";
            return false;
        }

        public bool EquipWeapon(Item weapon, out string errorMsg)
        {
            errorMsg = "";
            if (MainHand == null && OffHand == null)
            {
                MainHand = weapon;
                return true;
            }
            if (MainHand != null && 
                OffHand == null && 
                MainHand.EquipType.Type == EquipTypeName.OneHanded && 
                weapon.EquipType.Type == EquipTypeName.OneHanded)
            {
                OffHand = weapon;
                return true;
            }

            if (OffHand != null &&
                MainHand == null &&
                OffHand.EquipType.Type == EquipTypeName.OneHanded &&
                weapon.EquipType.Type == EquipTypeName.OneHanded)
            {
                MainHand = weapon;
                return true;
            }

            errorMsg = "Allready wearing two weapon items.";
            return false;
        }
    }
}
