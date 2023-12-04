using Onion.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Repositor.DataTransfer
{
    public interface IRepository<TEntity> : IDisposable where TEntity : BaseEntity
    {
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter);
        TEntity GetById(int entityId);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);

    }
}
