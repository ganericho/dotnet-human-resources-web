﻿using api.Contracts;
using api.Database;
using api.Utilities;
using api.Utilities.Handlers;

namespace api.Repositories;

public class AccountRepository : GeneralRepository<Account>, IAccountRepository
{
    public AccountRepository(HumanResourcesDbContext context) : base(context)
    {
    }

    public RepositoryHandler<Account> GetByEmail(string email)
    {
        try
        {
            var result = base.context.Set<Account>().FirstOrDefault(account => account.Email == email);
            
            if (result == null)
            {
                throw new Exception(MessageCollection.DataNotFound);
            }

            return new RepositoryHandler<Account>()
            {
                Result = result
            };
        }
        catch(Exception ex)
        {
            return new RepositoryHandler<Account>()
            {
                IsFailed = true,
                Exception = ex.InnerException.Message
            };
        }
    }
}
