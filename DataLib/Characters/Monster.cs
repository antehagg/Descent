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
    public class Monster : Character
    {
        public bool IsMaster { get; set; }
        public bool ActOne { get; set; }
        public AttackType AttackType { get; set; }
        public List<Dice> AttackDice { get; set; }
        public List<MonsterGroup> MonsterGroup { get; set; }
        public List<Ability> Abilities { get; set; }
    }
}
