using api.Models;
using api.Utilities;

namespace api.Contracts;

public interface IJobHistoryRepository  : IGeneralRepository<JobHistory>
{
    public RepositoryResult<IEnumerable<JobHistory>> GetByEmployeeGuid(Guid employeeGuid);
}
