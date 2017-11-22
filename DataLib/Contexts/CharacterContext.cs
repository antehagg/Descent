using System.Data.Entity;
using DataLib.Characters;
using DataLib.Characters.HeroData;
using DataLib.Characters.HeroData.CharacteristicSpecifiks;
using DataLib.Characters.MonsterData;

namespace DataLib.Contexts
{
    public class CharacterContext : DescentContext
    {
        public DbSet<Hero> Heroes { get; set; }
        public DbSet<Monster> Monsters { get; set; }
        public DbSet<Attributes> Attributes { get; set; }
        public DbSet<Characteristics> Characteristics { get; set; }
        public DbSet<MonsterGroup> MonsterGroups { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<EquipedItems> EquipedItems { get; set; }
        public DbSet<Archetype> Archetypes { get; set; }
        public DbSet<Defense> DefenseDices { get; set; }
    }
}

