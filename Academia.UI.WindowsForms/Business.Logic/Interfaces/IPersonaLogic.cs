using Business.Entities;

namespace Business.Logic.Interfaces
{
    public interface IPersonaLogic : ILogicBase
    {
    }

    public interface IPersonaLogic<TPersona> : ILogicBase<TPersona>
        where TPersona : Persona
    {
    }
}
