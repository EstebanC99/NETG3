using Business.Criterias.Personas;
using Business.Entities;
using Business.Views;
using System.Collections.Generic;

namespace Business.Logic.Interfaces
{
    public interface IPersonaLogic : ILogicBase
    {
        List<PersonaDataView> LeerTodas();

        PersonaDataView LeerPorID(int ID);

        List<PersonaDataView> SearchByPattern(PersonaCriteria criteria);
    }

    public interface IPersonaLogic<TPersona> : ILogicBase<PersonaDataView, TPersona>
        where TPersona : Persona
    {
        TPersonaDataView LeerPorID<TPersonaDataView>(int ID) where TPersonaDataView : IPersonaDataView, new();

        List<TPersonaDataView> LeerTodos<TPersonaDataView>() where TPersonaDataView : IPersonaDataView, new();
    }
}
