namespace DataLib.Items.ItemData
{
    public class AttackType
    {
        public int Id;
        public AttackTypeName Type;
    }

    public enum AttackTypeName { Melee, Ranged }
}