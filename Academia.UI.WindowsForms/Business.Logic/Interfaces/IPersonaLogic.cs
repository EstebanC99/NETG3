using Business.Entities;
using System.Collections.Generic;

namespace Business.Logic.Interfaces
{
    public interface IPersonaLogic : ILogicBase
    {
    }

    public interface IPersonaLogic<TPersona> : ILogicBase
        where TPersona : Persona
    {
        List<TPersona> GetAll();
    }
}
