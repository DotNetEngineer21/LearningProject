using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using CoreOSR.Configuration;
using CoreOSR.Web;

namespace CoreOSR.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class CoreOSRDbContextFactory : IDesignTimeDbContextFactory<CoreOSRDbContext>
    {
        public CoreOSRDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CoreOSRDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder(), addUserSecrets: true);

            CoreOSRDbContextConfigurer.Configure(builder, configuration.GetConnectionString(CoreOSRConsts.ConnectionStringName));

            return new CoreOSRDbContext(builder.Options);
        }
    }
}