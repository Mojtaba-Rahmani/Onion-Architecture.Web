using Microsoft.EntityFrameworkCore;
using Onion.Data.Common;
using Onion.Repositor.ApplicationContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Onion.Repositor.DataTransfer
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private OnionContext _context;
        private DbSet<TEntity> _dbSet;

        public Repository(OnionContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            IQueryable<TEntity> queryable = _dbSet;

            if (filter != null)
            {
                queryable = queryable.Where(filter);    
            }

            return queryable;
        }

        public TEntity GetById(int entityId)
        {
            return _dbSet.SingleOrDefault(u => u.Id == entityId);
        }

        public void Insert(TEntity entity)
        {
          _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;

            // Or
           // _dbSet.Update(entity).State = EntityState.Modified;
        }

        public void Delete(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;

            // Or
            //_dbSet.Remove(entity).State = EntityState.Deleted;
        }

        #region Dispose
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
