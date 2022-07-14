using Business.Entities;
using Business.Views;
using Cross.Exceptions;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Usuarios;
using System.Collections.Generic;

namespace Business.Logic.Usuarios
{
    public class UsuarioLogic : LogicBase<UsuarioDataView, Usuario, IUsuarioRepository>, IUsuarioLogic
    {
        public UsuarioLogic(Usuario usuario,
                            IUsuarioRepository repository,
                            IDbContextScopeFactory dbContextScopeFactory)
            : base(usuario, repository, dbContextScopeFactory)
        {

        }

        public UsuarioDataView LeerPorID(int ID)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                this.Entity = this.Repository.GetByID(ID);

                return new UsuarioDataView()
                {
                    ID = this.Entity.ID,
                    Nombre = this.Entity.Nombre,
                    Apellido = this.Entity.Apellido,
                    NombreUsuario = this.Entity.Nombre,
                    Clave = this.Entity.Clave,
                    Habilitado = this.Entity.Habilitado,
                    Email = this.Entity.Email,
                    CambiaClave = this.Entity.CambiaClave
                };
            }
        }

        public List<UsuarioDataView> LeerTodos()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.GetAll().ConvertAll(m =>
                new UsuarioDataView()
                {
                    ID = this.Entity.ID,
                    Nombre = this.Entity.Nombre,
                    Apellido = this.Entity.Apellido,
                    NombreUsuario = this.Entity.Nombre,
                    Clave = this.Entity.Clave,
                    Habilitado = this.Entity.Habilitado,
                    Email = this.Entity.Email,
                    CambiaClave = this.Entity.CambiaClave
                });
            }
        }

        protected override void Validar(UsuarioDataView usuario)
        {
            var validaciones = new ValidationException();

            if (string.IsNullOrEmpty(usuario.Nombre))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(usuario.Nombre)));

            if (string.IsNullOrEmpty(usuario.Apellido))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(usuario.Apellido)));

            if (string.IsNullOrEmpty(usuario.NombreUsuario))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(usuario.NombreUsuario)));

            if (string.IsNullOrEmpty(usuario.Clave))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(usuario.Clave)));

            validaciones.Throw();
        }

        protected override void Mapear(UsuarioDataView usuario)
        {
            this.Entity.Nombre = usuario.Nombre;
            this.Entity.Apellido = usuario.Apellido;
            this.Entity.Email = usuario.Email;
            this.Entity.NombreUsuario = usuario.NombreUsuario;
            this.Entity.Clave = usuario.Clave;
            this.Entity.CambiaClave = usuario.CambiaClave;
            this.Entity.Habilitado = usuario.Habilitado;
        }
    }
}
