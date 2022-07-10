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

        protected override void Validar(Usuario entity)
        {
            // Aca las validaciones

            this.Entity = entity;
        }
    }
}
