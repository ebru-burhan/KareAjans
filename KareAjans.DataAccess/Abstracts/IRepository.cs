    using KareAjans.Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace KareAjans.DataAccess.Abstracts
{
    public interface IRepository<T> where T : IEntity
    {
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> GetAll();
        IQueryable<T> GetIncluded(params Expression<Func<T, object>>[] includes);
        IQueryable<T> Get(Expression<Func<T, bool>> filter = null,
                Expression<Func<T, object>> include = null,
                Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                int? skip = null,
                int? take = null);
       
    }
}
