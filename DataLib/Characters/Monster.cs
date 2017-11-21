using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Abilities;
using DataLib.Characters.HeroData;
using DataLib.Characters.MonsterData;
using DataLib.Dices;
using DataLib.Items.ItemData;

namespace DataLib.Characters
{
    public class Monster : ICharacter
    {
        public int Id;
        public string Name;
        public Characteristics Characteristics;

        public bool IsMaster;
        public bool ActOne;
        public AttackType AttackType;
        public List<Dice> AttackDice;
        public List<MonsterGroup> MonsterGroup;
        public List<Ability> Abilities;
    }
}
