using Business.Entities;
using Business.Logic.Interfaces;
using Business.Views;
using Cross.Exceptions;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Usuarios;
using System.Collections.Generic;

namespace Business.Logic.Usuarios
{
    public class UsuarioLogic : LogicBase<UsuarioDataView, Usuario, IUsuarioRepository>, IUsuarioLogic
    {
        private IEntityLoaderLogicService EntityLoaderLogicService { get; set; }

        public UsuarioLogic(Usuario usuario,
                            IUsuarioRepository repository,
                            IDbContextScopeFactory dbContextScopeFactory,
                            IEntityLoaderLogicService entityLoaderLogicService)
            : base(usuario, repository, dbContextScopeFactory)
        {
            this.EntityLoaderLogicService = entityLoaderLogicService;
        }

        public UsuarioDataView LeerPorID(int ID)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                this.Entity = this.Repository.GetByID(ID);

                return new UsuarioDataView()
                {
                    ID = this.Entity.ID,
                    PersonaID = this.Entity.Persona.ID,
                    PersonaNombre = this.Entity.Persona?.Nombre,
                    PersonaApellido = this.Entity.Persona?.Apellido,
                    PersonaEmail = this.Entity.Persona?.Email,
                    NombreUsuario = this.Entity.NombreUsuario,
                    Clave = this.Entity.Clave,
                    Habilitado = this.Entity.Habilitado,
                    CambiaClave = this.Entity.CambiaClave,
                    RolUsuarioID = this.Entity.Rol.ID,
                    RolUsuarioDescripcion = this.Entity.Rol.Descripcion
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
                    ID = m.ID,
                    PersonaID = m.Persona.ID,
                    PersonaNombre = m.Persona?.Nombre,
                    PersonaApellido = m.Persona?.Apellido,
                    PersonaEmail = m.Persona?.Email,
                    NombreUsuario = m.NombreUsuario,
                    Clave = m.Clave,
                    Habilitado = m.Habilitado,
                    CambiaClave = m.CambiaClave,
                    RolUsuarioID = m.Rol.ID,
                    RolUsuarioDescripcion = m.Rol.Descripcion
                });
            }
        }

        protected override void Validar(UsuarioDataView usuario)
        {
            var validaciones = new ValidationException();

            if (string.IsNullOrEmpty(usuario.NombreUsuario))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(usuario.NombreUsuario)));

            if (string.IsNullOrEmpty(usuario.Clave))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(usuario.Clave)));

            if (this.EntityLoaderLogicService.GetByID<Persona>(usuario.PersonaID) == null)
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(Usuario.Persona)));

            if (usuario.RolUsuarioID == default(int))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(Usuario.Rol)));

            validaciones.Throw();
        }

        protected override void Mapear(UsuarioDataView usuario)
        {
            this.Entity.Persona = this.EntityLoaderLogicService.GetByID<Persona>(usuario.PersonaID);
            this.Entity.NombreUsuario = usuario.NombreUsuario;
            this.Entity.Clave = usuario.Clave;
            this.Entity.CambiaClave = usuario.CambiaClave;
            this.Entity.Habilitado = usuario.Habilitado;
            this.Entity.Rol = this.EntityLoaderLogicService.GetByID<Rol>(usuario.RolUsuarioID);
        }
    }
}
