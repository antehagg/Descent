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
    public class AbilityContext : DescentContext
    {
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<MovementAbilityEffect> MovementAbilityEffects { get; set; }
        public DbSet<RangeAbilityEffect> RangeAbilityEffects { get; set; }
        public DbSet<SurgeAbilityEffect> SurgeAbilityEffects { get; set; }
    }
}
