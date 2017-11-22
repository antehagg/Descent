using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib.Contexts
{
    public class DescentContext : DbContext
    {
        public DescentContext() : base("DescentEntities")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DescentContext>());
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<DescentContext>());
        }
    }
}
