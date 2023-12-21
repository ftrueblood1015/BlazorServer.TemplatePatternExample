using BlazorServer.TemplatePatternExample.Domain.Models;
using BlazorServer.TemplatePatternExample.Repositories;

namespace BlazorServer.TemplatePatternExample.Services
{
    public class ServiceBase<T, TRepository> : IServiceBase<T>
        where T : ModelBase
        where TRepository : IRepositoryBase<T>
    {

        protected readonly IRepositoryBase<T> Repo;

        public ServiceBase(IRepositoryBase<T> repo)
        {
            Repo = repo;
        }

        public T Add(T entity)
        {
            return Repo.Add(entity);
        }

        public virtual bool Delete(T entity)
        {
            return Repo.Delete(entity);
        }

        public bool DeleteById(int entityId)
        {
            return Repo.DeleteById(entityId);
        }

        public IEnumerable<T> Filter(Func<T, bool> predicate)
        {
            return Repo.Filter(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return Repo.GetAll();
        }

        public T? GetById(int id)
        {
            return Repo.GetById(id);
        }

        public virtual bool SafeDelete(T entity)
        {
            return true;
        }

        public T Update(T entity)
        {
            return Repo.Update(entity);
        }
    }
}
