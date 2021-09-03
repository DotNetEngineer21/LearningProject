using System.Threading.Tasks;
using Abp.Application.Services;
using CoreOSR.Install.Dto;

namespace CoreOSR.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}