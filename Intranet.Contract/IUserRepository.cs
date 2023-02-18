﻿using Intranet.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;

namespace Intranet.Contract;

public interface IUserRepository : IRepositoryBase<User>
{
    Task<IdentityResult> CreateAccount(User user, string password);
    Task<User?> FindByUserIdWithoutCancellationToken(int id);
    Task<User?> FindByUserNameAsync(string userName, CancellationToken cancellationToken = default);
    Task<User?> FindBySignalRConnectionId(string connectionId, CancellationToken cancellationToken = default);
    Task<User?> FindByGuidAsync(string guid, CancellationToken cancellationToken = default);
    Task<IList<string>> GetRolesAsync(User user);
    Task<IList<Claim>> GetClaimsAsync(User user);
    Task DeleteUser(User user, CancellationToken cancelationToken = default);
}
