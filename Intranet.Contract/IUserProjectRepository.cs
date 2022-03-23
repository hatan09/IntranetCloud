﻿using Intranet.Entities.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace Intranet.Contract
{
    public interface IUserProjectRepository : IRepositoryBase<UserProject>
    {
        Task<UserProject> FindByUserId(int userId, CancellationToken cancellationToken);
    }
}