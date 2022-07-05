using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceAccess.Repository
{
    public class AcademiaDbContext : DbContext
    {
        public AcademiaDbContext() : base("Name=AcademiaDb")
        {

        }
    }
}
