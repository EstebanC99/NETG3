using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public interface IUsuarioLogic : ILogicBase
    {
        Usuario GetByID(int ID);

        List<Usuario> GetAll();

        void AgregarUsuario(Usuario usuario);
    }
}
