using api.Models;
using api.Utilities;

namespace api.Contracts;

public interface IJobRepository : IGeneralRepository<Job>
{
    public RepositoryResult<Job> GetByName(string name);
    public RepositoryResult<Job> GetByCode(int code);
}
