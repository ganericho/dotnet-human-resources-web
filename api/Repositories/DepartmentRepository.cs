﻿using api.Contracts;
using api.Database;
using api.Utilities;
using api.Utilities.Handlers;

namespace api.Repositories
{
    public class DepartmentRepository : GeneralRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(HumanResourcesDbContext context) : base(context)
        {
        }

        public RepositoryHandler<Department> GetByCode(int code)
        {
            try
            {
                var result = base.context.Set<Department>().FirstOrDefault(department => department.Code == code);
                
                if(result == null)
                {
                    throw new Exception(MessageCollection.DataNotFound);
                }

                return new RepositoryHandler<Department>()
                {
                    Result = result
                };
            }
            catch(Exception ex)
            {
                return new RepositoryHandler<Department>()
                {
                    IsFailed = true,
                    Exception = ex.InnerException.Message
                };
            }
        }

        public RepositoryHandler<Department> GetByName(string name)
        {
            try
            {
                var result = base.context.Set<Department>().FirstOrDefault(department => department.Name.ToLower() == name.ToLower());

                if(result == null)
                {
                    throw new Exception(MessageCollection.DataNotFound);
                }

                return new RepositoryHandler<Department>()
                {
                    Result = result
                };
            }
            catch (Exception ex)
            {
                return new RepositoryHandler<Department>()
                {
                    IsFailed = true,
                    Exception = ex.InnerException.Message
                };
            }
        }
    }
}
