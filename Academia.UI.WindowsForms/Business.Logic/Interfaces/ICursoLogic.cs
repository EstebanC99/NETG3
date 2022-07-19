using Business.Entities;
using Business.Views;
using System.Collections.Generic;

namespace Business.Logic.Interfaces
{
    public interface ICursoLogic : ILogicBase<CursoDataView, Curso>
    {
        List<CursoDataView> LeerTodos();

        CursoDataView LeerPorID(int ID);

        List<ComisionDataView> LeerComisiones();

        List<MateriaDataView> LeerMaterias();
    }
}
