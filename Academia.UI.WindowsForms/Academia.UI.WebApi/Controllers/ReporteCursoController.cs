using Academia.UI.Globals;
using Academia.UI.Services.Academicos.InscripcionCurso;
using Academia.UI.Services.ReporteCursos;
using Academia.UI.ViewModels;
using System.Collections.Generic;
using System.Web.Http;

namespace Academia.UI.WebApi.Controllers
{
    [Authorize(Roles = nameof(RolesUsuario.Administrador) + "," + nameof(RolesUsuario.Alumno))]
    [Route("api/ReporteCurso")]
    public class ReporteCursosController : ApiControllerBase<IReporteCursosUIService>
    {
        public ReporteCursosController(IReporteCursosUIService uiService) : base(uiService)
        {

        }

        [HttpGet]
        [Route("api/ReporteCurso/{id}/LeerAlumnosInscriptos")]
        public ReporteCursoDetalleVM LeerAlumnosCurso(int id)
        {
            return this.UIService.LeerDetalleCurso(id);
        }

    }
}