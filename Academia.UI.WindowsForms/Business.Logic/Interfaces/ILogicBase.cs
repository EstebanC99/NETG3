using Business.Entities;
using Business.Views;
using System.Collections.Generic;

namespace Business.Logic
{
    public interface ILogicBase
    {
        
    }

    public interface ILogicBase<TDataView, TEntity> : ILogicBase
        where TEntity : BusinessEntity
        where TDataView : DataView
    {
        #region Metodos ABM

        void Registrar(TDataView dataView);

        void Modificar(TDataView dataView);

        void Eliminar(TDataView dataView);

        #endregion

        DataView GetByID(int ID);

        List<DataView> GetAll();
    }
}
