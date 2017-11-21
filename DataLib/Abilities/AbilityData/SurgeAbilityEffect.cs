using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Conditions;

namespace DataLib.Abilities.AbilityData
{
    public class SurgeAbilityEffect : IAbilityEffect
    {
        public int SurgeCost;
        public int Damage;
        public int Range;
        public Condition Condition;
        public bool CanSpendSurgeForFatigue;
    }
}
