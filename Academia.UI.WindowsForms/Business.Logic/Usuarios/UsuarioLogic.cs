using Business.Entities;
using Cross.Exceptions;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Usuarios;

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
            var validaciones = new ValidationException();

            if (string.IsNullOrEmpty(this.Entity.Nombre))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(this.Entity.Nombre)));

            if (string.IsNullOrEmpty(this.Entity.Apellido))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(this.Entity.Apellido)));

            if (string.IsNullOrEmpty(this.Entity.NombreUsuario))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(this.Entity.NombreUsuario)));

            if (string.IsNullOrEmpty(this.Entity.Clave))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(this.Entity.Clave)));

            validaciones.Throw();
        }

        protected override void MapearDatos(Usuario entity)
        {
            if (entity.State == BusinessEntity.States.New)
            {
                this.Entity = new Usuario();
            }
            else
            {
                this.Entity = this.Repository.GetByID(entity.ID);
            }

            base.MapearDatos(entity);

            this.Entity.Nombre = entity.Nombre;
            this.Entity.Apellido = entity.Apellido;
            this.Entity.Email = entity.Email;
            this.Entity.NombreUsuario = entity.NombreUsuario;
            this.Entity.Clave = entity.Clave;
            this.Entity.CambiaClave = entity.CambiaClave;
            this.Entity.Habilitado = entity.Habilitado;
        }
    }
}
