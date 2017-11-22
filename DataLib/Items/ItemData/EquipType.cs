namespace DataLib.Items.ItemData
{
    public class EquipType
    {
        public int Id { get; set; }
        public EquipTypeName Type { get; set; }
    }

    public enum EquipTypeName { OneHanded, TwoHanded, Armor, Other }
}