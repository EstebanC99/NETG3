using Academia.UI.Services.Academicos.InscripcionCurso;
using Academia.UI.ViewModels;
using Business.Utils;
using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Academia.UI.WebForm.Alumnos
{
    //[Authorize(Roles = nameof(RolesUsuario.Alumno))]
    public partial class AlumnoMainForm : System.Web.UI.Page
    {
        private IInscripcionCursoUIService InscripcionCursoUIService { get; set; }

        public CursoVM CursoDetalle { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.InscripcionCursoUIService = IoCContainer.Instance.TryResolve<IInscripcionCursoUIService>();

            if (!Page.IsPostBack)
            {
                this.LeerCursos();
            }
        }

        protected void Desmatricularse(object sender, CommandEventArgs e)
        {
            int.TryParse((string)e.CommandArgument, out var cursoID);

            var cursoFiltroVM = new CursoFiltroVM() { ID = cursoID };

            string response;

            try
            {
                this.InscripcionCursoUIService.Desmatricularse(cursoFiltroVM);
                response = string.Format("<script>alert('{0}')</script>", "Operacion exitosa!");
            }
            catch (Exception ex)
            {
                response = string.Format("<script>alert('{0}')</script>", ex.Message);
            }

            Response.Write(response);

            this.LeerCursos();
        }

        private void LeerCursos()
        {
            this.RepeaterCursos.DataSource = this.InscripcionCursoUIService.LeerCursosPorAlumnoLogueado();
            this.RepeaterCursos.DataBind();
        }
    }
}