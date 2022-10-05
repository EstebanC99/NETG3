using Academia.UI.Services.Academicos.InscripcionCurso;
using Academia.UI.ViewModels;
using Business.Utils;
using System;
using System.Web.UI.WebControls;

namespace Academia.UI.WebForm.Areas.Alumnos
{
    public partial class AlumnoListaCursos : System.Web.UI.Page
    {
        private IInscripcionCursoUIService InscripcionCursoUIService { get; set; }

        public CursoFiltroVM FiltroVM { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.FiltroVM = new CursoFiltroVM();
            this.InscripcionCursoUIService = IoCContainer.Instance.TryResolve<IInscripcionCursoUIService>();

            if (!Page.IsPostBack)
            {
                this.LeerCursos();
            }
        }

        protected void Inscribirse_Command(object sender, CommandEventArgs e)
        {
            int.TryParse((string)e.CommandArgument, out var cursoID);

            var inscripcionCursoVM = new InscripcionCursoVM() { CursoID = cursoID };

            string response;

            try
            {
                this.InscripcionCursoUIService.Inscribirse(inscripcionCursoVM);
                response = string.Format("<script>alert('{0}')</script>", "Inscripcion exitosa!");
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
            this.RepeaterCursos.DataSource = this.InscripcionCursoUIService.LeerCursosPorCriteria(new CursoFiltroVM());
            this.RepeaterCursos.DataBind();
        }
    }
}