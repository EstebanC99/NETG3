using Academia.UI.Services.Usuarios;
using Academia.UI.ViewModels;
using Security.Web;
using System.Web.Http;

namespace Academia.UI.WebApi.Controllers
{
    [AllowAnonymous]
    [Route("api/Login")]
    public class LoginController : ApiControllerBase<ILoginUIService>
    {
        public LoginController(ILoginUIService uiService) : base(uiService)
        {

        }

        [HttpPost]
        public IHttpActionResult Login(LoginVM login)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var usuarioVM = this.UIService.Login(login);

            if (usuarioVM != null)
            {
                var token = TokenGenerator.GenerateTokenJwt(usuarioVM.Username, 
                                                            usuarioVM.ID, 
                                                            usuarioVM.RolUsuarioID, 
                                                            usuarioVM.RolUsuarioDescripcion);
                return Ok(token);
            }

            return Unauthorized();
        }
    }
}