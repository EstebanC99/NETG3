using Business.Criterias.Personas;
using Business.Entities;
using Business.Logic.Interfaces;
using Business.Views;
using Cross.Exceptions;
using EntityFramework.DbContextScope.Interfaces;
using ResourceAccess.Repository.Personas;
using System;
using System.Collections.Generic;

namespace Business.Logic.Personas
{
    public class PersonaLogic : LogicBase<IPersonaRepository>, IPersonaLogic
    {

        public PersonaLogic(IDbContextScopeFactory dbContextScopeFactory,
                            IPersonaRepository repository)
            : base(dbContextScopeFactory, repository)
        {

        }

        public List<PersonaDataView> LeerTodas()
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                var personas = this.Repository.GetAll();

                return personas.ConvertAll<PersonaDataView>(p => new PersonaDataView()
                {
                    ID = p.ID,
                    Nombre = p.Nombre,
                    Apellido = p.Apellido,
                    Email = p.Email,
                    TipoPersonaID = p.TipoPersona
                });
            }
        }

        public PersonaDataView LeerPorID(int ID)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                var persona = this.Repository.GetByID(ID);

                if (persona == null)
                {
                    throw new ValidationException(Messages.SinResultados);
                }

                return new PersonaDataView()
                {
                    ID = persona.ID,
                    Nombre = persona.Nombre,
                    Apellido = persona.Apellido,
                    Email = persona.Email,
                    TipoPersonaID = persona.TipoPersona
                };
            }
        }

        public List<PersonaDataView> SearchByPattern(PersonaCriteria criteria)
        {
            using (this.DbContextScopeFactory.CreateReadOnly())
            {
                var personas = this.Repository.SearchByPattern(criteria);

                return personas.ConvertAll<PersonaDataView>(p => new PersonaDataView()
                {
                    ID = p.ID,
                    Nombre = p.Nombre,
                    Apellido = p.Apellido,
                    Legajo = p.Legajo,
                    Email = p.Email
                });
            }
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

            var personaRegistrada = this.Repository.ObtenerPorLegajo(persona.Legajo.Value);

            if (personaRegistrada != null && personaRegistrada.ID != persona.ID)
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
