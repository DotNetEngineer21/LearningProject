using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using CoreOSR.Authorization.Users;
using CoreOSR.MultiTenancy;

namespace CoreOSR.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}