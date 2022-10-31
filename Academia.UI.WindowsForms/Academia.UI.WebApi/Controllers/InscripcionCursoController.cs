using Academia.UI.Globals;
using Academia.UI.Services.Academicos.InscripcionCurso;
using Academia.UI.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace Academia.UI.WebApi.Controllers
{
    [Authorize(Roles = nameof(RolesUsuario.Administrador) + "," + nameof(RolesUsuario.Alumno))]
    [Route("api/InscripcionCurso")]
    public class InscripcionCursoController : ApiControllerBase<IInscripcionCursoUIService>
    {
        public InscripcionCursoController(IInscripcionCursoUIService uiService) : base(uiService)
        {

        }

        [HttpGet]
        [Route("api/InscripcionCurso/LeerCursos")]
        public List<CursoVM> LeerCursos()
        {
            return this.UIService.LeerCursos();
        }


        [HttpGet]
        [Route("api/InscripcionCurso/LeerCursosPorCriterio")]
        public List<CursoVM> LeerCursosPorCriterio(CursoFiltroVM filtro)
        {
            return this.UIService.LeerCursosPorCriteria(filtro);
        }

        [HttpPost]
        [Route("api/InscripcionCurso/Inscribirse")]
        [Authorize(Roles = nameof(RolesUsuario.Alumno))]
        public string Inscribirse(InscripcionCursoVM inscripcionCursoVM)
        {
            this.UIService.Inscribirse(inscripcionCursoVM);
            return "Inscripto correctamente";
        }

        [HttpPost]
        [Route("api/InscripcionCurso/Desmatricularse")]
        [Authorize(Roles = nameof(RolesUsuario.Alumno))]
        public string desmatricularse(CursoFiltroVM cursoFiltroVM)
        {
            this.UIService.Desmatricularse(cursoFiltroVM);
            return "Desmatriculado correctamente";
        }

        [HttpGet]
        [Route("api/InscripcionCurso/LeerCursosConCuposRestantes")]
        public List<CursoVM> LeerCursosConCupo()
        {
            return this.UIService.LeerCursosConCupos();
        }

        [HttpGet]
        [Route("api/InscripcionCurso/LeerCursosPorAlumnoLogueado")]
        public List<CursoVM> LeerCursosPorAlumnoLogueado()
        {
            return this.UIService.LeerCursosPorAlumnoLogueado();
        }
        
    }
}