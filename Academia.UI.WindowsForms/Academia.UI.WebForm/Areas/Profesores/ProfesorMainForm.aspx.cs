using Academia.UI.Services;
using Business.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Academia.UI.WebForm.Areas.Profesores
{
    public partial class ProfesorMainForm : System.Web.UI.Page
    {
        private IProfesorUIService ProfesorUIService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.ProfesorUIService = IoCContainer.Instance.TryResolve<IProfesorUIService>();

            if (!Page.IsPostBack)
            {
                this.LeerCursos();
            }
        }

        private void LeerCursos()
        {
            this.RepeaterCursos.DataSource = this.ProfesorUIService.LeerCursosPorProfesorLogueado();
            this.RepeaterCursos.DataBind();
        }

        protected void CargarNotas(object sender, CommandEventArgs args)
        {
            Response.Redirect($"ProfesorListaAlumnos.aspx?cursoID={args.CommandArgument}");
        }
    }
}