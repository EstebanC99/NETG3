using Academia.UI.Globals;
using Academia.UI.Services.Usuarios;
using Academia.UI.ViewModels;
using Business.Utils;
using Cross.Exceptions;
using Security.Desktop;
using System;
using System.Web;
using System.Web.Http;
using System.Web.Security;

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

                this.CreateTicket(usuario.Username);

                switch (usuario.RolUsuarioID)
                {
                    case RolesUsuario.Alumno:
                        Response.Redirect("../Alumnos/AlumnoMainForm.aspx", true);
                        break;
                    case RolesUsuario.Profesor:
                        Response.Redirect("../Profesores/ProfesorMainForm.aspx", true);
                        break;
                    default:
                        throw new ValidationException(Messages.UsuarioInvalidoParaLogin);
                }
            }
            catch (Exception ex)
            {
                var response = string.Format("<script>alert('{0}')</script>", ex.Message);
                Response.Write(response);
            }
        }

        private void CreateTicket(string userName)
        {
            var ticket = new FormsAuthenticationTicket(userName, false, 30);
            var cookiesString = FormsAuthentication.Encrypt(ticket);
            var cookies = new HttpCookie(FormsAuthentication.FormsCookieName, cookiesString);
            cookies.Path = FormsAuthentication.FormsCookiePath;
            Response.Cookies.Add(cookies);
        }
    }
}