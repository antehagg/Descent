using System.Collections.Generic;
using System.Dynamic;

namespace DataLib.Dices.DiceData
{
    public class DiceType
    {
        public int Id { get; set; }
        public DiceTypeName Type { get; set; }
        public List<Dice> Dices { get; set; }
    }

    public enum DiceTypeName { AttackDice, DefenseDice }
    
}