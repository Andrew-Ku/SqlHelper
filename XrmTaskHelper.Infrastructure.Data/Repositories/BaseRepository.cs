using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using XrmTaskHelper.Domain.Interfaces;

namespace XrmTaskHelper.Infrastructure.Data.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        private DbContext context;

        protected BaseRepository(DbContext context)
        {
            this.context = context;
        }

        public virtual IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            IQueryable<T> query = context.Set<T>();
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public IQueryable<T> Items { get { return context.Set<T>(); } }

        public virtual IQueryable<T> GetAll()
        {
            IQueryable<T> query = context.Set<T>();
            return query;
        }

        public virtual T Find(params object[] keyValues)
        {
            var result = context.Set<T>().Find(keyValues);
            if (result == null) throw new Exception("Сущность не найдена");
            return result;
        }

        public virtual void Add(T entity)
        {
            context.Set<T>().Add(entity);
        }

        public void AddRange(IEnumerable<T> entity)
        {
            context.Set<T>().AddRange(entity);
        }

        public virtual void Delete(object entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
        }

        public void Remove(T entity)
        {
            context.Set<T>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            context.Set<T>().RemoveRange(entities);
        }

        public void Remove(params object[] keyValues)
        {
            context.Set<T>().Remove(Find(keyValues));
        }

        public virtual int Save()
        {
            this.BeforeSave();
            return context.SaveChanges();
        }

        public Task<int> SaveAsync()
        {
            this.BeforeSave();
            return context.SaveChangesAsync();
        }

        /// <summary>
        /// Здесь можно задать, например, проверку правил валидации.
        /// </summary>
        protected virtual void BeforeSave()
        {
        }

        public void SetModified(object entity)
        {
            var entry = context.Entry(entity);
            if (entry.State == EntityState.Unchanged)
                entry.State = EntityState.Modified;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
                if (disposing)
                    context.Dispose();

            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public bool IsDetached(T entity)
        {
            return context.Entry(entity).State == EntityState.Detached;
        }
    }
}
