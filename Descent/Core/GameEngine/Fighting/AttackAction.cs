using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Characters;
using DataLib.Dices.DiceData;
using DataLib.Items;
using Descent.Core.GameEngine.Random;

namespace Descent.Core.GameEngine.Fighting
{
    public static class AttackAction
    {
        private static DiceSide RollAttackDice(RandomDice diceRoller, ICharacter attacker)
        {
            var hero = (Hero) attacker;
            var weapon = (Weapon) hero.Inventory.EquipedItems.MainHand;

            var totalDice = new DiceSide();

            foreach (var d in weapon.AttackDice)
            {
                var side = d.Sides[diceRoller.Roll(6)];
                totalDice.Add(side);
            }

            return totalDice;
        }

        private static DiceSide RollDefenseDice(RandomDice diceRoller, ICharacter defender)
        {
            var monster = (Monster)defender;
           
            var totalDice = new DiceSide();

            foreach (var d in monster.Characteristics.Defense.Dices)
            {
                var side = d.Sides[diceRoller.Roll(6)];
                totalDice.Add(side);
            }

            return totalDice;
        }

        public static void WeaponHit(RandomDice diceRoller, ICharacter attacker, ICharacter defender, out string combatLine)
        {
            combatLine = "";
            var attackRoll = RollAttackDice(diceRoller, attacker);
            var defenseRoll = RollDefenseDice(diceRoller, defender);

            combatLine += attackRoll + "\n";
            combatLine += defenseRoll + "\n";

            if (attackRoll.Miss == 0)
            {
                var damage = attackRoll.Hearth - defenseRoll.Shield;
                combatLine += damage + " damage done";
                if (attackRoll.Surge > 0)
                    combatLine += " and " + attackRoll.Surge + " surges\n";
            }
            else
            {
                combatLine += "Swing and miss!\n";
            }

        }
    }
}
