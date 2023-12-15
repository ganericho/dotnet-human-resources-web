using api.Contracts;
using api.Database;
using api.Utilities;
using api.Utilities.Handlers;

namespace api.Repositories;

public class JobHistoryRepository : GeneralRepository<JobHistory>, IJobHistoryRepository
{
    public JobHistoryRepository(HumanResourcesDbContext context) : base(context)
    {
    }

    public RepositoryHandler<IEnumerable<JobHistory>> GetByEmployeeGuid(Guid employeeGuid)
    {
        try
        {
            var result = base.context.Set<JobHistory>().Where(jobHistory => jobHistory.EmployeeGuid == employeeGuid);

            if (!result.Any())
            {
                throw new Exception(MessageCollection.DataNotFound);
            }

            return new RepositoryHandler<IEnumerable<JobHistory>>()
            {
                Result = result
            };
        }
        catch(Exception ex)
        {
            return new RepositoryHandler<IEnumerable<JobHistory>>()
            {
                IsFailed = true,
                Exception = ex.InnerException.Message,
                Result = Enumerable.Empty<JobHistory>()
            };
        }
    }
}
