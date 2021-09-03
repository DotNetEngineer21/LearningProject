using System.Collections.Generic;

namespace CoreOSR.MultiTenancy.HostDashboard.Dto
{
    public class GetIncomeStatisticsDataOutput
    {
        public List<IncomeStastistic> IncomeStatistics { get; set; }

        public GetIncomeStatisticsDataOutput(List<IncomeStastistic> incomeStatistics)
        {
            IncomeStatistics = incomeStatistics;
        }
    }
}