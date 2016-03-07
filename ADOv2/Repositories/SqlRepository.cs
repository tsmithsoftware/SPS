using ADOv2.Interfaces;
using System;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;

namespace ADOv2.Repositories
{
    public class SqlRepository<T> : IRepository<T>
                                where T : class, IEntity
    {
        protected ObjectSet<T> _objectSet;
        public SqlRepository(ObjectContext context)
        {
            _objectSet = context.CreateObjectSet<T>();
        }
        public IQueryable<T> FindAll()
        {
            return _objectSet;
        }
        public IQueryable<T> FindWhere(
                               Expression<Func<T, bool>> predicate)
        {
            return _objectSet.Where(predicate);
        }
        public T FindById(int id)
        {
            return _objectSet.Single(o => o.Id == id);
        }
        public void Add(T newEntity)
        {
            _objectSet.AddObject(newEntity);
        }
        public void Remove(T entity)
        {
            _objectSet.DeleteObject(entity);
        }
    }
}
