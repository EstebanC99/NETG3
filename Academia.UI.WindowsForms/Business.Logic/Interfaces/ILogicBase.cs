using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public interface ILogicBase
    {

    }

    public interface ILogicBase<TEntity> : ILogicBase
        where TEntity : BusinessEntity
    {
        void GuardarCambios(TEntity entity);
    }
}
