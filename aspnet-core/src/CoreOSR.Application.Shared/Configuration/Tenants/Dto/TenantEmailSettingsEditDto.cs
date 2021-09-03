using Abp.Auditing;
using CoreOSR.Configuration.Dto;

namespace CoreOSR.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}