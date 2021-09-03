using System.Threading.Tasks;
using Abp.Application.Services;
using CoreOSR.MultiTenancy.HostDashboard.Dto;

namespace CoreOSR.MultiTenancy.HostDashboard
{
    public interface IHostDashboardAppService : IApplicationService
    {
        Task<HostDashboardData> GetDashboardStatisticsData(GetDashboardDataInput input);

        Task<GetIncomeStatisticsDataOutput> GetIncomeStatistics(GetIncomeStatisticsDataInput input);

        Task<GetEditionTenantStatisticsOutput> GetEditionTenantStatistics(GetEditionTenantStatisticsInput input);
    }
}