using api.Models;
using api.Utilities;

namespace api.Contracts;

public interface IRoleRepository : IGeneralRepository<Role>
{
    public RepositoryResult<Role> GetByName(string name);
}
