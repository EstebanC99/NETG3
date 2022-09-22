using Business.Criterias.Usuarios;
using Business.Views;

namespace Business.Logic.Interfaces
{
    public interface ILoginLogic : ILogicBase
    {
        UsuarioDataView Login(UsuarioCriteria criteria);
    }
}
