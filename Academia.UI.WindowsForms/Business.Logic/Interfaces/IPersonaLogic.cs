using Business.Entities;
using Business.Views;
using System.Collections.Generic;

namespace Business.Logic.Interfaces
{
    public interface IPersonaLogic : ILogicBase
    {
    }

    public interface IPersonaLogic<TPersona> : ILogicBase<PersonaDataView, TPersona>
        where TPersona : Persona
    {
        TPersonaDataView LeerPorID<TPersonaDataView>(int ID) where TPersonaDataView : IPersonaDataView, new();

        List<TPersonaDataView> LeerTodos<TPersonaDataView>() where TPersonaDataView : IPersonaDataView, new();
    }
}
