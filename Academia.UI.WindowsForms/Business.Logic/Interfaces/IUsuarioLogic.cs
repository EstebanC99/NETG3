using Business.Entities;
using Business.Views;
using System.Collections.Generic;

namespace Business.Logic
{
    public interface IUsuarioLogic : ILogicBase<UsuarioDataView, Usuario>
    {
        UsuarioDataView LeerPorID(int ID);

        List<UsuarioDataView> LeerTodos();
    }
}
