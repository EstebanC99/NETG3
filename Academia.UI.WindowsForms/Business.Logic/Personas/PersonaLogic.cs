using Business.Entities;
using Business.Logic.Interfaces;
using Business.Views;
using Cross.Exceptions;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Personas;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.Logic.Personas
{
    public abstract class PersonaLogic : LogicBase<PersonaDataView, Persona, IPersonaRepository>, IPersonaLogic
    {

        public PersonaLogic(Persona entity,
                            IPersonaRepository repository,
                            IDbContextScopeFactory dbContextScopeFactory)
            : base(entity, repository, dbContextScopeFactory)
        {

        }

    }

    public abstract class PersonaLogic<TPersona, TPersonaRepository> : LogicBase<PersonaDataView, TPersona, TPersonaRepository>, IPersonaLogic<TPersona>
        where TPersona : Persona
        where TPersonaRepository : IPersonaRepository<TPersona>
    {
        public PersonaLogic(TPersona entity,
                            TPersonaRepository repository,
                            IDbContextScopeFactory dbContextScopeFactory)
            : base(entity, repository, dbContextScopeFactory)
        {

        }

        public TPersonaDataView LeerPorID<TPersonaDataView>(int ID)
            where TPersonaDataView : IPersonaDataView, new()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                this.Entity = this.Repository.GetByID(ID);

                return new TPersonaDataView()
                {
                    ID = this.Entity.ID,
                    Nombre = this.Entity.Nombre,
                    Apellido = this.Entity.Apellido,
                    Legajo = this.Entity.Legajo,
                    Direccion = this.Entity.Direccion,
                    Telefono = this.Entity.Telefono,
                    Email = this.Entity.Email,
                    FechaNacimiento = this.Entity.FechaNacimiento,
                    PlanID = this.Entity.Plan?.ID,
                    PlanDescripcion = this.Entity.Plan?.Descripcion
                };
            }
        }

        public List<TPersonaDataView> LeerTodos<TPersonaDataView>()
            where TPersonaDataView : IPersonaDataView, new()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                return this.Repository.GetAll().ConvertAll(m => 
                new TPersonaDataView()
                {
                    ID = m.ID,
                    Nombre = m.Nombre,
                    Apellido = m.Apellido,
                    Legajo = m.Legajo,
                    Direccion = m.Direccion,
                    Telefono = m.Telefono,
                    Email = m.Email,
                    FechaNacimiento = m.FechaNacimiento,
                    PlanID = m.Plan?.ID,
                    PlanDescripcion = m.Plan?.Descripcion
                });
            }
        }

        protected override void Validar(PersonaDataView persona)
        {
            var validaciones = new ValidationException();

            if (persona.Legajo == default(int) || !persona.Legajo.HasValue)
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXDebeSerNumerico, nameof(persona.Legajo)));

            if (string.IsNullOrEmpty(persona.Nombre))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(persona.Nombre)));

            if (string.IsNullOrEmpty(persona.Apellido))
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(persona.Apellido)));

            if (persona.FechaNacimiento == DateTime.MinValue)
                validaciones.AddValidationResult(string.Format(Messages.ElCampoXEsRequerido, nameof(persona.FechaNacimiento)));

            if (persona.FechaNacimiento.Date >= DateTime.Today.Date)
                validaciones.AddValidationResult(Messages.LaFechaDeNacimientoNoPuedeSerMayorOIgualALaFechaDeHoy);

            if (this.Repository.ObtenerPorLegajo(persona.Legajo.Value) != null)
                validaciones.AddValidationResult(string.Format(Messages.YaExisteUnaPersonaRegistradaConLegajoX, persona.Legajo));

            validaciones.Throw();
        }

        protected override void Mapear(PersonaDataView persona)
        {
            this.Entity.Nombre = persona.Nombre;
            this.Entity.Apellido = persona.Apellido;
            this.Entity.Direccion = persona.Direccion;
            this.Entity.Email = persona.Email;
            this.Entity.FechaNacimiento = persona.FechaNacimiento.Date;
            this.Entity.Legajo = persona.Legajo;
            this.Entity.Telefono = persona.Telefono;
        }
    }
}
