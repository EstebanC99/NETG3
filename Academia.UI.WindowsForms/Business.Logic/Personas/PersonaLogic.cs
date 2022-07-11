using Business.Entities;
using Business.Logic.Interfaces;
using Cross.Exceptions;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Personas;
using System;

namespace Business.Logic.Personas
{
    public abstract class PersonaLogic : LogicBase<Persona, IPersonaRepository>, IPersonaLogic
    {

        public PersonaLogic(Persona entity,
                            IPersonaRepository repository,
                            IDbContextScopeFactory dbContextScopeFactory)
            : base(entity, repository, dbContextScopeFactory)
        {

        }

    }

    public abstract class PersonaLogic<TPersona, TPersonaRepository> : LogicBase<TPersona, TPersonaRepository>, IPersonaLogic<TPersona>
        where TPersona : Persona
        where TPersonaRepository : IPersonaRepository<TPersona>
    {
        public PersonaLogic(TPersona entity,
                            TPersonaRepository repository,
                            IDbContextScopeFactory dbContextScopeFactory)
            : base(entity, repository, dbContextScopeFactory)
        {

        }

        protected override void Validar(TPersona entity)
        {
            var validaciones = new ValidationException();

            if (this.Entity.Legajo == default(int) || !this.Entity.Legajo.HasValue)
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXDebeSerNumerico, nameof(this.Entity.Legajo)));

            if (string.IsNullOrEmpty(this.Entity.Nombre))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(this.Entity.Nombre)));

            if (string.IsNullOrEmpty(this.Entity.Apellido))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(this.Entity.Apellido)));

            if (this.Entity.FechaNacimiento == DateTime.MinValue)
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(this.Entity.FechaNacimiento)));

            if (this.Entity.FechaNacimiento.Date >= DateTime.Today.Date)
                validaciones.AddValidationResult(Messages.LaFechaDeNacimientoNoPuedeSerMayorOIgualALaFechaDeHoy);

            if (this.Repository.ObtenerPorLegajo(this.Entity.Legajo.Value) != null)
                validaciones.AddValidationResult(string.Format(Messages.YaExisteUnaPersonaRegistradaConLegajoX, this.Entity.Legajo));

            validaciones.Throw();
        }

        protected override void MapearDatos(TPersona entity)
        {
            if (entity.State == BusinessEntity.States.New)
            {
                this.Entity = (TPersona)Activator.CreateInstance(typeof(TPersona));
            }
            else
            {
                this.Entity = this.Repository.GetByID(entity.ID);
            }
            
            base.MapearDatos(entity);

            this.Entity.Nombre = entity.Nombre;
            this.Entity.Apellido = entity.Apellido;
            this.Entity.Direccion = entity.Direccion;
            this.Entity.Email = entity.Email;
            this.Entity.FechaNacimiento = entity.FechaNacimiento.Date;
            this.Entity.Legajo = entity.Legajo;
            this.Entity.Telefono = entity.Telefono;
            this.Entity.State = entity.State;
        }
    }
}
