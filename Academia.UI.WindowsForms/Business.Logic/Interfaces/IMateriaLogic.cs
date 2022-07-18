using Business.Entities;
using Business.Views;
using System.Collections.Generic;

namespace Business.Logic.Interfaces
{
    public interface IMateriaLogic : ILogicBase<MateriaDataView, Materia>
    {
        List<MateriaDataView> LeerTodos();

        MateriaDataView LeerPorID(int ID);

        List<PlanDataView> LeerPlanes();
    }
}
