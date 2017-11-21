namespace DataLib.Dices.DiceData
{
    public class DiceType
    {
        public int Id;
        public DiceTypeName Type;
    }

    public enum DiceTypeName { AttackDice, DefenseDice }
}