using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLib.Conditions;

namespace DataLib.Contexts
{
    public class ConditionContext : DescentContext
    {
        public DbSet<Condition> Conditions { get; set; }
    }
}
