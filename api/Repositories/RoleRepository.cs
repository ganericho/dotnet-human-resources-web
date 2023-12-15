using api.Contracts;
using api.Database;
using api.Utilities;
using api.Utilities.Handlers;

namespace api.Repositories;

public class RoleRepository : GeneralRepository<Role>, IRoleRepository
{
    public RoleRepository(HumanResourcesDbContext context) : base(context)
    {
    }

    public RepositoryHandler<Role> GetByName(string name)
    {
        try
        {
            var result = base.context.Set<Role>().FirstOrDefault(role => role.Name.ToLower() == name.ToLower());

            if(result == null)
            {
                throw new Exception(MessageCollection.DataNotFound);
            }

            return new RepositoryHandler<Role>()
            {
                Result = result
            };
        }
        catch(Exception ex)
        {
            return new RepositoryHandler<Role>()
            {
                IsFailed = true,
                Exception = ex.InnerException.Message
            };
        }
    }
}
