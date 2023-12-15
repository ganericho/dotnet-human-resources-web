using api.Models;
using api.Utilities;

namespace api.Contracts;

public interface IEmployeeRepository : IGeneralRepository<Employee>
{
    public RepositoryResult<IEnumerable<Employee>> GetByJob(Guid jobGuid);
    public RepositoryResult<IEnumerable<Employee>> GetByDepartment(Guid departmentGuid);
}

