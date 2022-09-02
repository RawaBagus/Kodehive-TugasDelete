using Kodehive5.Data.Interface.Repositories;
using Kodehive.Service.Interface.Services;
using Kodehive5._0.Service.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodehive5._0.Service
{
    public class ServiceDependencyProfile
    {
        public static void Register(IConfiguration config, IServiceCollection services)
        {
            services.AddScoped<IMahasiswaService, MahasiswaService>();
            services.AddScoped<IDbService, DbService>();
        }
    }
}
