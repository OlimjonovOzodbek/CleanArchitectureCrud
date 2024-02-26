using Microsoft.Extensions.DependencyInjection;
using NajotCRUD.Application.Services.StudentServices;

namespace NajotCRUD.Application
{
    public static class ApplicationDI
    {
        public static IServiceCollection AddServicees(this IServiceCollection services)
        {
            services.AddScoped<Services.StudentServices.IStudentService, StudentService>();
            return services;
        }
    }
}
