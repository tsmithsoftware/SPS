using System;
using System.Linq;
using System.Linq.Expressions;

namespace ADOv2.Interfaces
{
    /**The IRepository<T> approach gives us some additional control over our queries because a 
    client has to invoke a method to get to an entity. Inside the method we could provide additional 
        checks and LINQ operators to enforce application constraints. **/
    public interface IRepository<T> where T : class, IEntity
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindWhere(Expression<Func<T, bool>> predicate);
        T FindById(int id);
        void Add(T newEntity);
        void Remove(T entity);
    }
}