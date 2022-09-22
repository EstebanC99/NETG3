using Academia.UI.ViewModels;
using Business.Criterias.Personas;
using Business.Logic.Interfaces;
using System.Collections.Generic;

namespace Academia.UI.Services.Personas
{
    public class PersonaUIService : UIService<IPersonaLogic, PersonaVM>, IPersonaUIService
    {
        public PersonaUIService(IPersonaLogic logic) : base(logic)
        {
        }

        public List<PersonaVM> LeerTodas()
        {
            return this.Logic.LeerTodas().ConvertAll<PersonaVM>(p => new PersonaVM()
            {
                ID = p.ID,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Email = p.Email,
                TipoPersonaID = p.TipoPersonaID
            });
        }

        public PersonaVM LeerPorID(int ID)
        {
            var persona = this.Logic.LeerPorID(ID);

            return new PersonaVM()
            {
                ID = persona.ID,
                Nombre = persona.Nombre,
                Apellido = persona.Apellido,
                Email = persona.Email,
                TipoPersonaID = persona.TipoPersonaID
            };
        }

        public List<PersonaVM> BuscarPorPatron(PersonaFiltroVM filtroVM)
        {
            var criteria = new PersonaCriteria()
            {
                Descripcion = filtroVM.Descripcion
            };

            var personas = this.Logic.SearchByPattern(criteria);

            return personas.ConvertAll<PersonaVM>(p => new PersonaVM()
            {
                ID = p.ID,
                Nombre = p.Nombre,
                Apellido = p.Apellido,
                Email = p.Email,
                TipoPersonaID = p.TipoPersonaID
            });
        }
    }
}
