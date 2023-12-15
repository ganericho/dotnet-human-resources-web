using api.Models;
using api.Utilities;

namespace api.Contracts;

public interface IAccountRoleRepository : IGeneralRepository<AccountRole>
{
    public RepositoryResult<IEnumerable<AccountRole>> GetByAccountGuid(Guid accountGuid);
}
