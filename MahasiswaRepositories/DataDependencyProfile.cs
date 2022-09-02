using Kodehive5.Data.Interface.Repositories;
using Kodehive.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Kodehive.Data
{
    public class DataDependencyProfile
    {
        public static void Register(IConfiguration config, IServiceCollection services)
        {
            services.AddScoped<IMahasiswaRepository, MahasiswaRepository>();

        }
    }
}
