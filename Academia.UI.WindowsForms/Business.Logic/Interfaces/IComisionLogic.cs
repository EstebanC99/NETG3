using Business.Entities;
using Business.Views;
using System.Collections.Generic;

namespace Business.Logic.Interfaces
{
    public interface IComisionLogic : ILogicBase<ComisionDataView, Comision>
    {
        List<ComisionDataView> LeerTodos();

        ComisionDataView LeerPorID(int ID);

        List<PlanDataView> LeerPlanes();
    }
}
