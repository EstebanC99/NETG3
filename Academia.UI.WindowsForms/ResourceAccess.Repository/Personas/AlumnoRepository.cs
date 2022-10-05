using Business.Entities;
using Business.Views;
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


        public List<CursoDataView> LeerCursosPorAlumnoLogueado(int alumnoID)
        {
            var inscripciones = this.DbSet.FirstOrDefault(a => a.ID == alumnoID).Cursos;

            if (inscripciones != null)
            {
                return inscripciones.ToList().ConvertAll<CursoDataView>(c => new CursoDataView()
                {
                    ID = c.Curso.ID,
                    AnioCalendario = c.Curso.AnioCalendario,
                    Cupo = c.Curso.Cupo,
                    MateriaID = c.Curso.Materia.ID,
                    MateriaDescripcion = c.Curso.Materia.Descripcion,
                    ComisionID = c.Curso.Comision.ID,
                    ComisionDescripcion = c.Curso.Comision.Descripcion,
                    PlanID = c.Curso.Materia.Plan.ID,
                    PlanDescripcion = c.Curso.Materia.Plan.Descripcion,
                    EspecialidadID = c.Curso.Materia.Plan.Especialidad.ID,
                    EspecialidadDescripcion = c.Curso.Materia.Plan.Especialidad.Descripcion,
                    HsSemanales = c.Curso.Materia.HsSemanales,
                    HsTotales = c.Curso.Materia.HsTotales,
                    EstaInscripto = true
                });
            }

            return new List<CursoDataView>();
        }
    }
}
