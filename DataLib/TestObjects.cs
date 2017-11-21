using System.Collections.Generic;
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

namespace DataLib
{
    public class TestObjects
    {
        public string ErrorMessage;

        public Dice BlueDice;
        public Dice RedDice;
        public Dice YellowDice;
        public Dice GreenDice;
        public Dice BrownDice;
        public Dice GrayDice;
        public Dice BlackDice;

        public Condition DiseaseCondition;

        public Ability DiseaseAbility;
        public Ability ShamblingAbility;
        public Ability ReachAbility;

        public Weapon WarHammer;
        public Item SignetRing;

        public Hero Warrior;
        public Monster Zombie;

        public TestObjects()
        {
            CreateDices();
            CreateItems();
            CreateAbilities();
            CreateConditions();
            CreateHeroes();
            CreateMonsters();
        }

        private void CreateDices()
        {
            BlueDice = new Dice
            {
                Id = 1,
                Color = "Blue",
                DiceType = new DiceType
                {
                    Id = 1,
                    Type = DiceTypeName.AttackDice
                },
                Sides = new List<DiceSide>
                {
                    new DiceSide
                    {
                        Miss = 1
                    },
                    new DiceSide
                    {
                        Value = 2,
                        Hearth = 2,
                        Surge = 1
                    },
                    new DiceSide
                    {
                        Value = 3,
                        Hearth = 2
                    },
                    new DiceSide
                    {
                        Value = 4,
                        Hearth = 2
                    },
                    new DiceSide
                    {
                        Value = 5,
                        Hearth = 1
                    },
                    new DiceSide
                    {
                        Value = 6,
                        Hearth = 1,
                        Surge = 1
                    }
                }
            };

            RedDice = new Dice
            {
                Id = 2,
                Color = "Red",
                DiceType = new DiceType
                {
                    Id = 1,
                    Type = DiceTypeName.AttackDice
                },
                Sides = new List<DiceSide>
                {
                    new DiceSide
                    {
                        Hearth = 1
                    },
                    new DiceSide
                    {
                        Hearth = 2
                    },
                    new DiceSide
                    {
                        Hearth = 2
                    },
                    new DiceSide
                    {
                        Hearth = 2
                    },
                    new DiceSide
                    {
                        Hearth = 3
                    },
                    new DiceSide
                    {
                        Hearth = 3,
                        Surge = 1
                    }
                }
            };

            YellowDice = new Dice
            {
                Id = 3,
                Color = "Yellow",
                DiceType = new DiceType
                {
                    Id = 1,
                    Type = DiceTypeName.AttackDice
                },
                Sides = new List<DiceSide>
                {
                    new DiceSide
                    {
                        Value = 1,
                        Surge = 1
                    },
                    new DiceSide
                    {
                        Value = 1,
                        Hearth = 1
                    },
                    new DiceSide
                    {
                        Value = 2,
                        Hearth = 1
                    },
                    new DiceSide
                    {
                        Surge = 1,
                        Hearth = 1
                    },
                    new DiceSide
                    {
                        Hearth = 2
                    },
                    new DiceSide
                    {
                        Hearth = 2,
                        Surge = 1
                    }
                }
            };

            GreenDice = new Dice
            {
                Id = 4,
                Color = "Green",
                DiceType = new DiceType
                {
                    Id = 1,
                    Type = DiceTypeName.AttackDice
                },
                Sides = new List<DiceSide>
                {
                    new DiceSide
                    {
                        Hearth = 1
                    },
                    new DiceSide
                    {
                        Surge = 1
                    },
                    new DiceSide
                    {
                        Value = 1,
                        Surge = 1
                    },
                    new DiceSide
                    {
                        Value = 1,
                        Hearth = 1
                    },
                    new DiceSide
                    {
                        Hearth = 1,
                        Surge = 1
                    },
                    new DiceSide
                    {
                        Value = 1,
                        Hearth = 1,
                        Surge = 1
                    }
                }
            };

            BrownDice = new Dice
            {
                Id = 5,
                Color = "Brown",
                DiceType = new DiceType
                {
                    Id = 2,
                    Type = DiceTypeName.DefenseDice
                },
                Sides = new List<DiceSide>
                {
                    new DiceSide
                    {
                        
                    },
                    new DiceSide
                    {
                        
                    },
                    new DiceSide
                    {
                       
                    },
                    new DiceSide
                    {
                        Shield = 1
                    },
                    new DiceSide
                    {
                        Shield = 1
                    },
                    new DiceSide
                    {
                        Shield = 2
                    }
                }
            };

            GrayDice = new Dice
            {
                Id = 6,
                Color = "Gray",
                DiceType = new DiceType
                {
                    Id = 2,
                    Type = DiceTypeName.DefenseDice
                },
                Sides = new List<DiceSide>
                {
                    new DiceSide
                    {

                    },
                    new DiceSide
                    {
                        Shield = 1
                    },
                    new DiceSide
                    {
                        Shield = 1
                    },
                    new DiceSide
                    {
                        Shield = 1
                    },
                    new DiceSide
                    {
                        Shield = 2
                    },
                    new DiceSide
                    {
                        Shield = 3
                    }
                }
            };

            BlackDice = new Dice
            {
                Id = 7,
                Color = "Black",
                DiceType = new DiceType
                {
                    Id = 2,
                    Type = DiceTypeName.DefenseDice
                },
                Sides = new List<DiceSide>
                {
                    new DiceSide
                    {

                    },
                    new DiceSide
                    {
                        Shield = 2
                    },
                    new DiceSide
                    {
                        Shield = 2
                    },
                    new DiceSide
                    {
                        Shield = 2
                    },
                    new DiceSide
                    {
                        Shield = 3
                    },
                    new DiceSide
                    {
                        Shield = 4
                    }
                }
            };
        }

        private void CreateConditions()
        {
            DiseaseCondition = new Condition
            {
                Id = 1,
                Name = "Disease",
                Description =
                    "At the start of your turn, test Willpower. If you pass, discard this card or token. If you fail, suffer 1 Fatigue and keep this card or token."
            };
        }

        private void CreateAbilities()
        {
            DiseaseAbility = new Ability
            {
                Id = 2,
                Name = "Disease",
                Description =
                    "If this attack deals at least 1 damage (after the defense roll), the target is Diseased.",
                AbilityEffects = new List<IAbilityEffect>
                {
                    new SurgeAbilityEffect
                    {
                        SurgeCost = 1,
                        Condition = DiseaseCondition
                    }
                }
            };

            ShamblingAbility = new Ability
            {
                Id = 1,
                Name = "Shambling",
                Description = "This monster may not perform more than 1 move action during a single turn.",
                AbilityEffects = new List<IAbilityEffect>
                {
                    new MovementAbilityEffect
                    {
                        MovementEffectRestriction = 1
                    }
                }
            };

            ReachAbility = new Ability
            {
                Id = 4,
                Name = "Reach",
                Description =
                    "The Reach keyword allows the figure to use a Melee attack to target a figure up to two spaces away, rather than only adjacent spaces. The target still needs to be in line of sight.",
                AbilityEffects = new List<IAbilityEffect>
                {
                    new RangeAbilityEffect
                    {
                        AddedRange = 1
                    }
                }
            };
        }

        private void CreateItems()
        {
            WarHammer = new Weapon
            {
                Id = 1,
                Name = "War Hammer",
                AttackDice = new List<Dice>
                {
                    BlueDice,
                    RedDice
                },
                AttackType = new AttackType
                {
                    Id = 1,
                    Type = AttackTypeName.Melee
                },
                EquipType = new EquipType
                {
                    Id = 1,
                    Type = EquipTypeName.TwoHanded
                },
                Traits = new List<ItemTrait>
                {
                    new ItemTrait
                    {
                      Id = 2,
                      Type = ItemTraitType.Hammer
                    }
                },
                Abilities = new List<Ability>
                {
                    DamageAbility(1, 2),
                    ReachAbility,
                    new Ability
                    {
                        Id = 5,
                        Description = "You cannot spend Surge to recover fatigue.",
                        AbilityEffects = new List<IAbilityEffect>
                        {
                            new SurgeAbilityEffect
                            {
                                CanSpendSurgeForFatigue = false
                            }
                        }
                    }
                }
            };

            SignetRing = new Item
            {
                Id = 2,
                Name = "Signet Ring",
                EquipType = new EquipType
                {
                    Id = 2,
                    Type = EquipTypeName.Other
                },
                Traits = new List<ItemTrait>
                {
                    new ItemTrait
                    {
                        Id = 1,
                        Type = ItemTraitType.Ring
                    }
                }
            };
        }

        private void CreateHeroes()
        {
            Warrior = new Hero
            {
                Id = 1,
                Name = "Alys Raine",
                Archetype = new Archetype
                {
                    Id = 1,
                    Type = ArchetypeName.Warrior
                },
                Characteristics = new Characteristics
                {
                    Health = new Health
                    {
                        Id = 1,
                        Name = "Health",
                        Value = 12
                    },
                    Defense = new Defense
                    {
                        Id = 2,
                        Name = "Defense",
                        Dices = new List<Dice>
                        {
                            GrayDice
                        }
                    },
                    Stamina = new Stamina
                    {
                        Id = 3,
                        Name = "Stamina",
                        Value = 4
                    },
                    Speed = new Characteristic
                    {
                        Id = 4,
                        Name = "Speed",
                        Value = 4
                    }
                },
                Attributes = new Attributes
                {
                    Might = new Attribute
                    {
                        Id = 1,
                        Name = "Might",
                        Value = 3
                    },
                    Knowledge = new Attribute
                    {
                        Id = 2,
                        Name = "Knowledge",
                        Value = 4
                    },
                    Willpower = new Attribute
                    {
                        Id = 3,
                        Name = "Willpower",
                        Value = 3
                    },
                    Awareness = new Attribute
                    {
                        Id = 4,
                        Name = "Awareness",
                        Value = 1
                    }
                },
                Inventory = new Inventory
                {
                    Gold = 100,
                    Items = new List<Item>(),
                    EquipedItems = new EquipedItems()
                }
            };

            var equipWarriorWeapon = Warrior.Inventory.EquipedItems.EquipWeapon(WarHammer, out var weaponErrorMsg);
            var equipWarriorOther = Warrior.Inventory.EquipedItems.EquipOther(SignetRing, out var otherErrorMsg);

            if (!equipWarriorWeapon)
                ErrorMessage += weaponErrorMsg + "\n";
            if(!equipWarriorOther)
                ErrorMessage += otherErrorMsg + "\n";
        }

        private void CreateMonsters()
        {
            Zombie = new Monster
            {
                Id = 1,
                Name = "Zombie",
                Characteristics = new Characteristics
                {
                    Health = new Health
                    {
                        Id = 1,
                        Name = "Health",
                        Value = 3
                    },
                    Defense = new Defense
                    {
                        Id = 2,
                        Name = "Defense",
                        Dices = new List<Dice>
                        {
                            BrownDice
                        }
                    },
                    Stamina = new Stamina
                    {
                        Id = 3,
                        Name = "Stamina"
                    },
                    Speed = new Characteristic
                    {
                        Id = 4,
                        Name = "Speed",
                        Value = 3
                    }
                },
                ActOne = true,
                IsMaster = false,
                AttackType = new AttackType
                {
                    Id = 1,
                    Type = AttackTypeName.Melee
                },
                MonsterGroup = new List<MonsterGroup>
                {
                    new MonsterGroup
                    {
                        Heroes = 2,
                        Minions = 2,
                        Masters = 1
                    },
                    new MonsterGroup
                    {
                        Heroes = 3,
                        Minions = 3,
                        Masters = 1
                    },
                    new MonsterGroup
                    {
                        Heroes = 4,
                        Minions = 4,
                        Masters = 1
                    }
                },
                AttackDice = new List<Dice>
                {
                    BlueDice,
                    YellowDice
                },
                Abilities = new List<Ability>
                {
                    ShamblingAbility,
                    DiseaseAbility,
                    DamageAbility(1, 1)
                }
            };
        }
        private Ability DamageAbility(int surgeCost, int damage)
        {
            return new Ability
            {
                Id = 3,
                Name = "Damage",
                AbilityEffects = new List<IAbilityEffect>
                {
                    new SurgeAbilityEffect
                    {
                        SurgeCost = surgeCost,
                        Damage = damage
                    }
                }
            };
        }
    }
}
