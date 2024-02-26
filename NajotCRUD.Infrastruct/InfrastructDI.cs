using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NajotCRUD.Infrastruct.Persistance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajotCRUD.Infrastruct
{
    public static class InfrastructDI
    {
        public static IServiceCollection AddContexts(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext> (options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DefCon"));
            });
            return services;
        }
    }
}
