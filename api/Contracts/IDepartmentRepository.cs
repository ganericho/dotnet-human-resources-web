using api.Models;
using api.Utilities;

namespace api.Contracts;

public interface IDepartmentRepository : IGeneralRepository<Department>
{
    public RepositoryResult<Department> GetByName(string name);
    public RepositoryResult<Department> GetByCode(int code);
}
