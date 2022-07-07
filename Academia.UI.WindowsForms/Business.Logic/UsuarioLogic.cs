using Business.Entities;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
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

        public void AgregarUsuario(Usuario usuario)
        {
            using (var context = this.DbContextScopeFactory.Create())
            {
                this.ValidarUsuario(usuario);

                this.Repository.Add(this.Entity);

                context.SaveChanges();
            }
        }

        private void ValidarUsuario(Usuario usuario)
        {
            // Aca validaciones

            this.Entity = usuario;
        }
    }
}
