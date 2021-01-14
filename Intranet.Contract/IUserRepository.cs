﻿using Intranet.Entities.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Intranet.Contract
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        Task<User> FindByUserName(string userName, CancellationToken cancellationToken = default)
    }
}
