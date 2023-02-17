using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace KPMG.DoIt.Application.DependencyInjection
{
    public static class ApplicationDependency
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddMediatR((config) =>
            {
                config.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });
        }
    }
}
