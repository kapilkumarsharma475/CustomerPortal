using System.Collections.Generic;

namespace CustomerPortal.WebApi.Repositories.Interface
{
    internal interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetbyId(long id);
        T Insert(T entity);
        T Update(T entity);
        void Delete(int id);
    }
}
