using KareAjans.Entity.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace KareAjans.DataAccess.Abstracts
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        // TODO: BaseRepository Abstract yaptık bunun durumuna ilerde bak

        private readonly DataContext context;
        public BaseRepository(DataContext _context)
        {
            context = _context;
        }

        //virtual çünkü     bazılarını add delete update yapmak istemediğimz için
        public virtual T Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity;
        }

        public virtual void Delete(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }
        public virtual void Update(T entity)
        {
            // TODO: attach çalışmasını kontrol et
            context.Set<T>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }


        //--------------------
        public IQueryable<T> GetAll()
        {
            return Get();
        }

        //
        public IQueryable<T> GetIncluded(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = context.Set<T>();
            foreach (var include in includes)
            {
                query = query.Include(include);
            }
            return query;
        }


        public IQueryable<T> Get(Expression<Func<T, bool>> filter = null, Expression<Func<T, object>> include = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, int? skip = null, int? take = null)
        {
            return GetQueryable(filter, include, orderBy, skip, take);
        }


        protected virtual IQueryable<T> GetQueryable(Expression<Func<T, bool>> filter = null,
                                                     Expression<Func<T, object>> include = null,
                                                     Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                     int? skip = null,
                                                     int? take = null)
        {
            //istenilen çekildi şuan ve query atandı organization çektik diyelim
            IQueryable<T> query = context.Set<T>();
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (include != null)
            {
                query = query.Include(include);
            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            if (skip.HasValue)
            {
                query = query.Skip(skip.Value);
            }
            if (take.HasValue)
            {
                query = query.Take(take.Value);
            }

            //EF değişklikleri kontrol etmesin delete ettirmedi veriyi tutuyo hayırdır diyo
            return query.AsNoTracking();
        }


    }
}
