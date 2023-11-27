using Microsoft.AspNetCore.Identity;

namespace InsuranceOrgWebAPI.Common.Authorization;


public class InMemoryRoleStore<TRole> : IRoleStore<TRole>
    where TRole : IdentityRole
{
    private readonly List<TRole> roles = new List<TRole>();

    public Task<IdentityResult> CreateAsync(TRole role, CancellationToken cancellationToken)
    {
        roles.Add(role);
        return Task.FromResult(IdentityResult.Success);
    }

    public Task<IdentityResult> UpdateAsync(TRole role, CancellationToken cancellationToken)
    {
        // Implement update logic here
        return Task.FromResult(IdentityResult.Success);
    }

    public Task<IdentityResult> DeleteAsync(TRole role, CancellationToken cancellationToken)
    {
        roles.Remove(role);
        return Task.FromResult(IdentityResult.Success);
    }

    public Task<string> GetRoleIdAsync(TRole role, CancellationToken cancellationToken)
    {
        return Task.FromResult(role.Id);
    }

    public Task<string> GetRoleNameAsync(TRole role, CancellationToken cancellationToken)
    {
        return Task.FromResult(role.Name);
    }

    public Task SetRoleNameAsync(TRole role, string roleName, CancellationToken cancellationToken)
    {
        role.Name = roleName;
        return Task.CompletedTask;
    }

    public Task<string?> GetNormalizedRoleNameAsync(TRole role, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SetNormalizedRoleNameAsync(TRole role, string? normalizedName, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<TRole?> FindByIdAsync(string roleId, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<TRole?> FindByNameAsync(string normalizedRoleName, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    // Implement other IRoleStore<TRole> methods as needed

    public void Dispose()
    {
        // Cleanup resources, if needed
    }
}