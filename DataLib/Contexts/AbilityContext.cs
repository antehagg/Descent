using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Abilities;
using DataLib.Abilities.AbilityData;

namespace DataLib.Contexts
{
    public class AbilityContext
    {
        private readonly DescentContext _context;
        public AbilityContext(DescentContext context)
        {
            _context = context;
        }

        public Ability GetAbilityById(int abilityId)
        {
            var ability = _context.Abilities.Single(a => a.Id == abilityId);
            ability.AbilityEffects = GetAbilityEffectsByAbilityId(abilityId);

            return ability;
        }

        public List<AbilityEffect> GetAbilityEffectsByAbilityId(int abilityId)
        {
            return _context.Abilities.Where(a => a.Id == abilityId).SelectMany(a => a.AbilityEffects).ToList();
        }
    }
}
