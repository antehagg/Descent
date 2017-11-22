namespace DataLib.Items.ItemData
{
    public class AttackType
    {
        public int Id { get; set; }
        public AttackTypeName Type { get; set; }
    }

    public enum AttackTypeName { Melee, Ranged }
}