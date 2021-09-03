using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CoreOSR.MultiTenancy.HostDashboard.Dto;

namespace CoreOSR.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}