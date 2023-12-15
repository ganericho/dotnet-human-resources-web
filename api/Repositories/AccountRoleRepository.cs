using api.Contracts;
using api.Database;
using api.Models;
using api.Utilities;
using api.Utilities.Handlers;

namespace api.Repositories;

public class AccountRoleRepository : GeneralRepository<AccountRole>, IAccountRoleRepository
{
    public AccountRoleRepository(HumanResourcesDbContext context) : base(context)
    {
    }
    public RepositoryHandler<IEnumerable<AccountRole>> GetByAccountGuid(Guid accountGuid)
    {
        try
        {
            var result = base.context.Set<AccountRole>().Where(accountRole => accountRole.AccountGuid == accountGuid);

            if (!result.Any())
            {
                throw new Exception(MessageCollection.DataNotFound);
            }

            return new RepositoryHandler<IEnumerable<AccountRole>>()
            {
                Result = result
            };
        }
        catch(Exception ex)
        {
            return new RepositoryHandler<IEnumerable<AccountRole>>()
            {
                IsFailed = true,
                Exception = ex.InnerException.Message,
                Result = Enumerable.Empty<AccountRole>()
            };
        }
    }
}
