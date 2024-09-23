using Core.Persistence.Repositories;
using Core.Security.Entities;
using Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Services.Repositories;

namespace Persistence.Repositories;

public class UserRepository:EfRepositoryBase<User,int,BaseDbContext>,IUserRepository
{
    public UserRepository(BaseDbContext context):base(context) 
    { 
        
    }
    
}
