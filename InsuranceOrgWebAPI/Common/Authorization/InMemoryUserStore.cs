using Microsoft.AspNetCore.Identity;

namespace InsuranceOrgWebAPI.Common.Authorization;

public class InMemoryUserStore<TUser> : IUserStore<TUser>,
    IUserPasswordStore<TUser>,
    IUserRoleStore<TUser>
    where TUser : IdentityUser
{
    private readonly List<TUser> users = new List<TUser>();

    public Task<string> GetUserIdAsync(TUser user, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<string?> GetUserNameAsync(TUser user, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SetUserNameAsync(TUser user, string? userName, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<string?> GetNormalizedUserNameAsync(TUser user, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SetNormalizedUserNameAsync(TUser user, string? normalizedName, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IdentityResult> CreateAsync(TUser user, CancellationToken cancellationToken)
    {
        users.Add(user);
        return Task.FromResult(IdentityResult.Success);
    }

    public Task<IdentityResult> UpdateAsync(TUser user, CancellationToken cancellationToken)
    {
        // Implement update logic here
        return Task.FromResult(IdentityResult.Success);
    }

    public Task<IdentityResult> DeleteAsync(TUser user, CancellationToken cancellationToken)
    {
        users.Remove(user);
        return Task.FromResult(IdentityResult.Success);
    }

    public Task<TUser> FindByIdAsync(string userId, CancellationToken cancellationToken)
    {
        return Task.FromResult(users.FirstOrDefault(u => u.Id == userId));
    }

    public Task<TUser> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
    {
        return Task.FromResult(users.FirstOrDefault(u => u.NormalizedUserName == normalizedUserName));
    }

    // Implement other IUserStore<TUser> methods as needed

    public void Dispose()
    {
        // Cleanup resources, if needed
    }

    public Task SetPasswordHashAsync(TUser user, string? passwordHash, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<string?> GetPasswordHashAsync(TUser user, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> HasPasswordAsync(TUser user, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task AddToRoleAsync(TUser user, string roleName, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task RemoveFromRoleAsync(TUser user, string roleName, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IList<string>> GetRolesAsync(TUser user, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> IsInRoleAsync(TUser user, string roleName, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IList<TUser>> GetUsersInRoleAsync(string roleName, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}