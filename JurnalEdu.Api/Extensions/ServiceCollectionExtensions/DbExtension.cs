using JurnalEdu.DataLayer.EfContexts;
using Microsoft.EntityFrameworkCore;

namespace JurnalEdu.Api.Extensions
{
    public static class DbExtension
    {
        public static void AddDB(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContextPool<BaseDbContext>(options =>
            {
                string connectionString = configuration.GetConnectionString("SqlServerConnectionString");

                options.UseSqlServer(
                    connectionString: connectionString,
                    sqlServerOptionsAction: options => options.EnableRetryOnFailure());
            });
        }
    }
}
