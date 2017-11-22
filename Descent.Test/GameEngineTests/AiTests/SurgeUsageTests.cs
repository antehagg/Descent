using DataLib.Abilities.AbilityData;
using Descent.Core.GameEngine.Ai;
using NUnit.Framework;

namespace Descent.Test.GameEngineTests.AiTests
{
    public class SurgeUsageTests
    {
        [Test]
        public void TestSurgeWithMissingRange()
        {
            var possibleSurges = new List<SurgeAbilityEffect>();
            var surgeUsage = new SurgeUsage();
            surgeUsage.GetSurgesFromRoll(2, 1, 1,
            5, )

        }
    }
}
