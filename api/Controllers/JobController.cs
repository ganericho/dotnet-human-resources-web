using api.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class JobController : ControllerBase
{

    private readonly IDepartmentRepository departmentRepository;
    private readonly IEmployeeRepository employeeRepository;
    private readonly IAccountRepository accountRepository;
    private readonly IJobRepository jobRepository;

    public JobController(IDepartmentRepository departmentRepository, IEmployeeRepository employeeRepository, IAccountRepository accountRepository, IJobRepository jobRepository)
    {
        this.departmentRepository = departmentRepository;
        this.employeeRepository = employeeRepository;
        this.accountRepository = accountRepository;
        this.jobRepository = jobRepository;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        try
        {
            var getJobs = jobRepository.GetAll();

            if (getJobs.IsFailed)
            {
                throw new Exception(getJobs.Exception);
            }

            return Ok(getJobs.Result);
        }
        catch(Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }

    [HttpGet("{guid}")]
    public IActionResult GetByGuid(Guid guid)
    {
        try
        {
            var getJob = jobRepository.GetByGuid(guid);

            if (getJob.IsFailed)
            {
                throw new Exception(getJob.Exception);
            }

            return Ok(getJob.Result);
        }
        catch(Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
        }
    }
}
