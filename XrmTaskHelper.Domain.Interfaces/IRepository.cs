using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace XrmTaskHelper.Domain.Interfaces
{
    public interface IRepository<T> : IDisposable where T : class
    {
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        T Find(params object[] keyValues);
        IQueryable<T> GetAll();
        IQueryable<T> Items { get; }
        void Add(T entity);
        void AddRange(IEnumerable<T> entity);
        /// <summary>
        /// Remove from context
        /// </summary>
        /// <param name="entity"></param>
        void Remove(T entity);
        /// <summary>
        /// Remove from context by key
        /// </summary>
        void Remove(params object[] keyValues);

        void RemoveRange(IEnumerable<T> entities);

        int Save();

        Task<int> SaveAsync();

        void SetModified(object entity);

        bool IsDetached(T entity);
    }
}
