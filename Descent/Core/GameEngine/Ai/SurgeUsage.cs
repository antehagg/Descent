using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Abilities.AbilityData;

namespace Descent.Core.GameEngine.Ai
{
    public class SurgeUsage
    {
        public List<SurgeAbilityEffect> GetSurgesFromRoll(int surges, int damage, int missingRange,
            int defenderHealth, List<SurgeAbilityEffect> possibleSurges)
        {
            var surgeList = new List<SurgeAbilityEffect>();
            var tempSurgeList = new List<SurgeAbilityEffect>();
            var remainingSurges = surges;

            // First get range
            if (missingRange > 0 && remainingSurges > 0)
            {
                tempSurgeList.Clear();
                tempSurgeList.AddRange(surgeList.Where(s => s.Range > 0 && s.SurgeCost <= surges).OrderByDescending(s => s.Range));

                var counter = 0;
                while (missingRange > 0)
                {
                    var tempSurge = tempSurgeList[counter];
                    surgeList.Add(tempSurge);
                    surges -= tempSurge.SurgeCost;
                    missingRange -= tempSurge.Range;

                    counter++;
                }
            }

            //Second get damage
            if (damage <= 0 && remainingSurges > 0)
            {
                tempSurgeList.Clear();
                tempSurgeList.AddRange(surgeList.Where(s => s.Damage > 0 && s.SurgeCost <= surges).OrderByDescending(s => s.Damage));

                var counter = 0;
                while (damage <= 0)
                {
                    var tempSurge = tempSurgeList[counter];
                    surgeList.Add(tempSurge);
                    surges -= tempSurge.SurgeCost;
                    damage += tempSurge.Damage;

                    counter++;
                }
            }

            return surgeList;
        }
    }
}
