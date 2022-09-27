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
        public void Inscribirse(InscripcionCursoVM inscripcionCursoVM)
        {
            this.UIService.Inscribirse(inscripcionCursoVM);
        }

    }
}