using Microsoft.AspNetCore.Authorization;

namespace eCommerce.Backend.Security.Authorization.Requirements
{
    public class AdminRoleRequirement : IAuthorizationRequirement
    {
        public AdminRoleRequirement() {}
    }
}
