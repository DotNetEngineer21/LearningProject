using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using CoreOSR.EntityFrameworkCore;

namespace CoreOSR.HealthChecks
{
    public class CoreOSRDbContextHealthCheck : IHealthCheck
    {
        private readonly DatabaseCheckHelper _checkHelper;

        public CoreOSRDbContextHealthCheck(DatabaseCheckHelper checkHelper)
        {
            _checkHelper = checkHelper;
        }

        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = new CancellationToken())
        {
            if (_checkHelper.Exist("db"))
            {
                return Task.FromResult(HealthCheckResult.Healthy("CoreOSRDbContext connected to database."));
            }

            return Task.FromResult(HealthCheckResult.Unhealthy("CoreOSRDbContext could not connect to database"));
        }
    }
}
