using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Config;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ResourceAccess.Repository
{
    public class AcademiaDbContext : DbContext, IDbContext
    {
        public AcademiaDbContext() : base("Name=AcademiaDb")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetAssembly(typeof(DummyConfig)));
        }
    }
}
