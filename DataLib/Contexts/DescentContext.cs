using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Abilities;
using DataLib.Abilities.AbilityData;
using DataLib.Characters;
using DataLib.Characters.HeroData;
using DataLib.Characters.HeroData.CharacteristicSpecifiks;
using DataLib.Characters.MonsterData;
using DataLib.Conditions;
using DataLib.Dices;
using DataLib.Dices.DiceData;
using DataLib.Items;
using DataLib.Items.ItemData;

namespace DataLib.Contexts
{
    public class DescentContext : DbContext
    {
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<AbilityEffect> AbilityEffects { get; set; }

        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Attributes> Attributes { get; set; }
        public DbSet<Characteristics> Characteristics { get; set; }
        public DbSet<MonsterGroup> MonsterGroups { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<EquipedItems> EquipedItems { get; set; }
        public DbSet<Archetype> Archetypes { get; set; }
        public DbSet<Defense> DefenseDices { get; set; }

        public DbSet<Condition> Conditions { get; set; }

        public DbSet<Dice> Dices { get; set; }
        public DbSet<DiceSide> DiceSides { get; set; }
        public DbSet<DiceType> DiceTypes { get; set; }

        public DbSet<Item> Items { get; set; }
        public DbSet<AttackType> AttackTypes { get; set; }
        public DbSet<EquipType> EquipTypes { get; set; }
        public DbSet<ItemTrait> ItemTraits { get; set; }

        public DescentContext() : base("DescentEntities")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DescentContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DescentContext>());
        }
    }
}
