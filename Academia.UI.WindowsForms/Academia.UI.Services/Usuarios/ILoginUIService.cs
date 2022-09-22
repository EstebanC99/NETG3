using Academia.UI.ViewModels;

namespace Academia.UI.Services.Usuarios
{
    public interface ILoginUIService : IUIService<LoginVM>
    {
        LoginVM Login(LoginVM login);
    }
}