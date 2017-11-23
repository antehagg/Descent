using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Abilities.AbilityData;
using DataLib.Characters;
using DataLib.Items;

namespace DataLib.Abilities
{
    public class Ability
    {
        public Ability()
        {
            AbilityEffects = new HashSet<AbilityEffect>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<AbilityEffect> AbilityEffects { get; set; }
        public List<Monster> Monster { get; set; }
        public List<Item> Items { get; set; }
    }
}
