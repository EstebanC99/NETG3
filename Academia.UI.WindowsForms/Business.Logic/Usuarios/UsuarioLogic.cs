using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Usuarios;
using System.Collections.Generic;

namespace Business.Logic.Usuarios
{
    public class UsuarioLogic : LogicBase<Usuario, IUsuarioRepository>, IUsuarioLogic
    {
        public UsuarioLogic(Usuario usuario,
                            IUsuarioRepository repository,
                            IDbContextScopeFactory dbContextScopeFactory)
            : base(usuario, repository, dbContextScopeFactory)
        {

        }

        public Usuario GetByID(int ID)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.GetByID(ID);
            }
        }

        public List<Usuario> GetAll()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.GetAll();
            }
        }
    }
}
