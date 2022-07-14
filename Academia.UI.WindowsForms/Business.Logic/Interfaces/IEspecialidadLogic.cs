using Business.Entities;
using Business.Views;
using System.Collections.Generic;

namespace Business.Logic.Interfaces
{
    public interface IEspecialidadLogic : ILogicBase<EspecialidadDataView, Especialidad>
    {
        EspecialidadDataView LeerPorID(int ID);

        List<EspecialidadDataView> LeerTodos();
    }
}
