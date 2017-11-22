using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Conditions;

namespace DataLib.Abilities.AbilityData
{
    public class SurgeAbilityEffect : AbilityEffect
    {
        public int SurgeCost { get; set; }
        public int Damage { get; set; }
        public int Range { get; set; }
        public Condition Condition { get; set; }
        public bool CanSpendSurgeForFatigue { get; set; }
    }
}
