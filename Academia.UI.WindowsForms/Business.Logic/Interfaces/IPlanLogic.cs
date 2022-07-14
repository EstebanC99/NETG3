using Business.Entities;
using Business.Views;
using System.Collections.Generic;

namespace Business.Logic.Interfaces
{
    public interface IPlanLogic : ILogicBase<PlanDataView, Plan>
    {
        List<PlanDataView> LeerTodos();

        PlanDataView LeerPorID(int ID);

        List<EspecialidadDataView> LeerEspecialidades();
    }
}
