using api.Utilities;

namespace api.Contracts;

public interface IGeneralRepository<T>
{
    RepositoryResult<T> GetByGuid(Guid guid);
    RepositoryResult<string> Update(T entity);
    RepositoryResult<string> Create(T entity);
    RepositoryResult<string> Delete(T entity);
    RepositoryResult<IEnumerable<T>> GetAll();
}
