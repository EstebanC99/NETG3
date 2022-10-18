using Academia.UI.Globals;
using Academia.UI.Services.Usuarios;
using Academia.UI.ViewModels;
using Business.Utils;
using Security.Desktop;
using System;
using System.Web.Http;

namespace Academia.UI.WebForm.Login
{
    [AllowAnonymous]
    public partial class LoginForm : System.Web.UI.Page
    {
        private ILoginUIService LoginUIService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            this.LoginUIService = IoCContainer.Instance.TryResolve<ILoginUIService>();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var loginVM = new LoginVM()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            try
            {
                var usuario = this.LoginUIService.Login(loginVM);

                SessionInfo.Instance.SetInfo(usuario.ID, usuario.Username, usuario.RolUsuarioID);

                Session["userID"] = usuario.ID;
                Session["username"] = usuario.Username;
                Session["rolUsuarioID"] = usuario.RolUsuarioID;
                Session["rol"] = usuario.RolUsuarioDescripcion;

                switch (usuario.RolUsuarioID)
                {
                    case RolesUsuario.Alumno:
                        Response.Redirect("../Alumnos/AlumnoMainForm.aspx");
                        break;
                    case RolesUsuario.Profesor:
                        Response.Redirect("../Profesores/ProfesorMainForm.aspx");
                        break;
                    default:
                        Response.Redirect("../Alumnos/AlumnoMainForm.aspx");
                        break;
                }
            }
            catch (Exception ex)
            {
                var response = string.Format("<script>alert('{0}')</script>", ex.Message);
                Response.Write(response);
            }
        }
    }
}