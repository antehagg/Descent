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

            // Get missing range
            if (missingRange > 0 && remainingSurges > 0)
            {
                tempSurgeList.Clear();
                tempSurgeList.AddRange(possibleSurges.Where(s => s.Range > 0 && s.SurgeCost <= surges).
                    OrderByDescending(r => r.Range).ThenByDescending(d => d.Damage).ThenBy(s => s.SurgeCost));

                var counter = 0;
                while (missingRange > 0)
                {
                    var tempSurge = tempSurgeList[counter];
                    surgeList.Add(tempSurge);
                    remainingSurges -= tempSurge.SurgeCost;
                    missingRange -= tempSurge.Range;

                    counter++;
                }

                possibleSurges = possibleSurges.Except(surgeList).ToList();
            }

            // Try to kill
            if (remainingSurges > 0)
            {
                tempSurgeList.Clear();
                tempSurgeList.AddRange(possibleSurges.Where(s => s.Damage > 0 && s.SurgeCost <= surges)
                    .OrderByDescending(d => d.Damage).ThenBy(s => s.SurgeCost));

                var tempRemainingSurges = remainingSurges;
                var tempDamageSurgeLsit = new List<SurgeAbilityEffect>();

                foreach (var s in tempSurgeList)
                {
                    if (tempRemainingSurges > 0 && s.SurgeCost <= tempRemainingSurges)
                    {
                        tempRemainingSurges -= s.SurgeCost;
                        tempDamageSurgeLsit.Add(s);
                        defenderHealth -= s.Damage;
                    }
                }

                if (defenderHealth <= 0)
                {
                    possibleSurges = possibleSurges.Except(tempDamageSurgeLsit).ToList();
                    surgeList.AddRange(tempDamageSurgeLsit);
                    remainingSurges = tempRemainingSurges;
                }
            }

            // Get missing damage
            if (damage <= 0 && remainingSurges > 0)
            {
                tempSurgeList.Clear();
                tempSurgeList.AddRange(possibleSurges.Where(s => s.Damage > 0 && s.SurgeCost <= surges)
                    .OrderByDescending(d => d.Damage).ThenBy(s => s.SurgeCost));

                var counter = 0;
                while (damage <= 0)
                {
                    var tempSurge = tempSurgeList[counter];
                    possibleSurges.Remove(tempSurge);
                    surgeList.Add(tempSurge);
                    remainingSurges -= tempSurge.SurgeCost;
                    damage += tempSurge.Damage;

                    counter++;
                }

                possibleSurges = possibleSurges.Except(surgeList).ToList();
            }

            // Get conditions
            if (remainingSurges > 0 && damage > 0)
            {
                tempSurgeList.Clear();
                tempSurgeList.AddRange(possibleSurges.Where(s => s.Condition != null && s.SurgeCost <= surges));

                foreach (var s in tempSurgeList)
                {
                    if (remainingSurges > 0 && s.SurgeCost <= remainingSurges)
                    {
                        remainingSurges -= s.SurgeCost;
                        surgeList.Add(s);
                    }
                }

                possibleSurges = possibleSurges.Except(surgeList).ToList();
            }

            // Get damage if surges still remains
            if (remainingSurges > 0)
            {
                tempSurgeList.Clear();
                tempSurgeList.AddRange(possibleSurges.Where(s => s.Damage > 0 && s.SurgeCost <= surges).
                    OrderByDescending(d => d.Damage).ThenBy(s => s.SurgeCost));

                foreach (var s in possibleSurges)
                {
                    if (remainingSurges > 0 && s.SurgeCost <= remainingSurges)
                    {
                        remainingSurges -= s.SurgeCost;
                        surgeList.Add(s);
                    }
                }
            }

            return surgeList;
        }
    }
}
