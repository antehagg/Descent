using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using DataLib.Abilities.AbilityData;
using DataLib.Conditions;
using Descent.Core.GameEngine.Ai;
using NUnit.Framework;

namespace Descent.Tests.CoreTests.GameEngineTests.AiTests
{
    public class SurgeUsageTests
    {
        [Test]
        public void TestSurgeWithMissingRange()
        {
            var possibleSurges = new List<SurgeAbilityEffect>
            {
                new SurgeAbilityEffect
                {
                    CanSpendSurgeForFatigue = true,
                    Damage = 2,
                    SurgeCost = 1
                },
                new SurgeAbilityEffect
                {
                    CanSpendSurgeForFatigue = true,
                    Damage = 1,
                    Range = 1,
                    SurgeCost = 1
                },
                new SurgeAbilityEffect
                {
                    CanSpendSurgeForFatigue = true,
                    Condition = new Condition
                    {
                        Id = 1,
                        Name = "Disease",
                    },
                    SurgeCost = 1
                },
                new SurgeAbilityEffect
                {
                    CanSpendSurgeForFatigue = true,
                    Damage = 2,
                    Range = 1,
                    SurgeCost = 1
                }
            };
            var surgeUsage = new SurgeUsage();
            var surges = surgeUsage.GetSurgesFromRoll(2, 1, 1,
                5, possibleSurges);

            var range = surges.Sum(s => s.Range);
            var surgeCost = surges.Sum(s => s.SurgeCost);
                
            Assert.AreEqual(2, surges.Count);
            Assert.AreEqual(2, surgeCost);
            Assert.IsTrue(range > 0);
        }

        [Test]
        public void TestSurgeWithMissingDamage()
        {
            var possibleSurges = new List<SurgeAbilityEffect>
            {
                new SurgeAbilityEffect
                {
                    CanSpendSurgeForFatigue = true,
                    Damage = 2,
                    SurgeCost = 1
                },
                new SurgeAbilityEffect
                {
                    CanSpendSurgeForFatigue = true,
                    Damage = 0,
                    Range = 1,
                    SurgeCost = 1
                },
                new SurgeAbilityEffect
                {
                    CanSpendSurgeForFatigue = true,
                    Condition = new Condition
                    {
                        Id = 1,
                        Name = "Disease",
                    },
                    SurgeCost = 1
                },
                new SurgeAbilityEffect
                {
                    CanSpendSurgeForFatigue = true,
                    Damage = 2,
                    Range = 1,
                    SurgeCost = 2
                }
            };
            var surgeUsage = new SurgeUsage();
            var surges = surgeUsage.GetSurgesFromRoll(2, 0, 0,
                5, possibleSurges);

            var damage = surges.Sum(s => s.Damage);
            var surgeCost = surges.Sum(s => s.SurgeCost);

            Assert.AreEqual(2, surges.Count);
            Assert.AreEqual(2, surgeCost);
            Assert.IsTrue(damage > 0);
        }

        [Test]
        public void TestSurgeWithNothingMissing()
        {
            var possibleSurges = new List<SurgeAbilityEffect>
            {
                new SurgeAbilityEffect
                {
                    CanSpendSurgeForFatigue = true,
                    Damage = 2,
                    SurgeCost = 1
                },
                new SurgeAbilityEffect
                {
                    CanSpendSurgeForFatigue = true,
                    Damage = 1,
                    Range = 1,
                    SurgeCost = 1
                },
                new SurgeAbilityEffect
                {
                    CanSpendSurgeForFatigue = true,
                    Condition = new Condition
                    {
                        Id = 1,
                        Name = "Disease",
                    },
                    SurgeCost = 1
                },
                new SurgeAbilityEffect
                {
                    CanSpendSurgeForFatigue = true,
                    Damage = 2,
                    Range = 1,
                    SurgeCost = 1
                }
            };
            var surgeUsage = new SurgeUsage();
            var surges = surgeUsage.GetSurgesFromRoll(2, 1, 0,
                5, possibleSurges);

            var surgeCost = surges.Sum(s => s.SurgeCost);

            Assert.AreEqual(2, surges.Count);
            Assert.AreEqual(2, surgeCost);
        }

        [Test]
        public void TestSurgeWithKillRange()
        {
            var possibleSurges = new List<SurgeAbilityEffect>
            {
                new SurgeAbilityEffect
                {
                    CanSpendSurgeForFatigue = true,
                    Damage = 2,
                    SurgeCost = 1
                },
                new SurgeAbilityEffect
                {
                    CanSpendSurgeForFatigue = true,
                    Damage = 1,
                    Range = 1,
                    SurgeCost = 1
                },
                new SurgeAbilityEffect
                {
                    CanSpendSurgeForFatigue = true,
                    Condition = new Condition
                    {
                        Id = 1,
                        Name = "Disease",
                    },
                    SurgeCost = 1
                },
                new SurgeAbilityEffect
                {
                    CanSpendSurgeForFatigue = true,
                    Damage = 2,
                    Range = 1,
                    SurgeCost = 1
                }
            };
            var surgeUsage = new SurgeUsage();
            var surges = surgeUsage.GetSurgesFromRoll(2, 1, 0,
                4, possibleSurges);

            var surgeCost = surges.Sum(s => s.SurgeCost);
            var damage = surges.Sum(s => s.Damage);

            Assert.AreEqual(2, surges.Count);
            Assert.AreEqual(2, surgeCost);
            Assert.AreEqual(4, damage);
        }
    }
}
