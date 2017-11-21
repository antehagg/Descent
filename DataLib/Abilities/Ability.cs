using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Abilities.AbilityData;

namespace DataLib.Abilities
{
    public class Ability
    {
        public int Id;
        public string Name;
        public string Description;
        public List<IAbilityEffect> AbilityEffects;
    }
}
