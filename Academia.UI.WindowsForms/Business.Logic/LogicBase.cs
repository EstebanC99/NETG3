using Business.Entities;
using ResourceAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Logic
{
    public abstract class LogicBase<TEntity, TRepository> : ILogicBase
        where TEntity : BusinessEntity
        where TRepository : IRepository<TEntity>
    {
        protected TEntity Entity { get; set; }

        protected TRepository Repository { get; set; }

        public LogicBase(TEntity entity, TRepository repository)
        {
            this.Entity = entity;
            this.Repository = repository;
        }

    }
}
