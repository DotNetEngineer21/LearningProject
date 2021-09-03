using System.Threading.Tasks;
using Abp.Application.Services;
using CoreOSR.Configuration.Host.Dto;

namespace CoreOSR.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
