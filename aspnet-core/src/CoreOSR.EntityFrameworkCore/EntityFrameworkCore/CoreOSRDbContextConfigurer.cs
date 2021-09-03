using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace CoreOSR.EntityFrameworkCore
{
    public static class CoreOSRDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<CoreOSRDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<CoreOSRDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}