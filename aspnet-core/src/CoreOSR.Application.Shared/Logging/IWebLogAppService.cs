using Abp.Application.Services;
using CoreOSR.Dto;
using CoreOSR.Logging.Dto;

namespace CoreOSR.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
