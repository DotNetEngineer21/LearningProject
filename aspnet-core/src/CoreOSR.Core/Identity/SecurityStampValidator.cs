using Abp.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using CoreOSR.Authorization.Roles;
using CoreOSR.Authorization.Users;
using CoreOSR.MultiTenancy;

namespace CoreOSR.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options, 
            SignInManager signInManager,
            ISystemClock systemClock)
            : base(options, signInManager, systemClock)
        {
        }
    }
}