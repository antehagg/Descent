namespace DataLib.Items.ItemData
{
    public class EquipType
    {
        public int Id;
        public EquipTypeName Type;
    }

    public enum EquipTypeName { OneHanded, TwoHanded, Armor, Other }
}