using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceAccess.Repository.Personas
{
    public class AlumnoRepository : PersonaRepository<Alumno>, IAlumnoRepository
    {
        public AlumnoRepository(IAmbientDbContextLocator ambientDbContextLocator) 
            : base(ambientDbContextLocator)
        {

        }
    }
}
