using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceAccess.Repository.Academicos
{
    public class PlanRepository : Repository<Plan>, IPlanRepository
    {
        public PlanRepository(IAmbientDbContextLocator ambientDbContextLocator)
            : base(ambientDbContextLocator)
        {

        }


    }
}
