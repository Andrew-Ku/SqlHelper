using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using XrmTaskHelper.Core.Interfaces;
using XrmTaskHelper.Domain.Interfaces;

namespace XrmTaskHelper.Services.DomainServices
{
    public class BaseDomainService<T> where T : class, IEntity
    {
        protected readonly IRepository<T> _repository;

        public BaseDomainService(IRepository<T> repository)
        {
            _repository = repository;
        }
        
        public virtual IQueryable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public virtual IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties)
        {
            return _repository.AllIncluding(includeProperties);
        }

        public virtual T Find(int id)
        {
            var result = _repository.GetAll().Single(c => c.Id == id);
            if (result == null) throw new ArgumentNullException();
            return result;
        }

        public virtual void Add(T entity)
        {
            _repository.Add(entity);
        }

        public void AddRange(IEnumerable<T> entity)
        {
            _repository.AddRange(entity);
        }

        public virtual int Save()
        {
            return _repository.Save();
        }

        public Task<int> SaveAsync()
        {
            return _repository.SaveAsync();
        }

        public virtual void Remove(T entity)
        {
            if (_repository.IsDetached(entity))
                Find(entity.Id);

            _repository.Remove(entity);
        }

        public virtual void RemoveRange(IEnumerable<T> entity)
        {
            _repository.RemoveRange(entity);
        }

        public virtual void Remove(int id)
        {
            Find(id);
            _repository.Remove(id);
        }

        public Type GetModelType()
        {
            return typeof(T);
        }

    }
}
