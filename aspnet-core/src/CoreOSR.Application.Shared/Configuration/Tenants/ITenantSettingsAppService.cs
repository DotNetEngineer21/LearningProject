using System.Threading.Tasks;
using Abp.Application.Services;
using CoreOSR.Configuration.Tenants.Dto;

namespace CoreOSR.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
