using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.Abilities.AbilityData
{
    public class AbilityEffect
    {
        public AbilityEffect()
        {
            Abilities = new HashSet<Ability>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Ability> Abilities { get; set; }
    }
}
