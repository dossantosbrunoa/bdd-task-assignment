using Microsoft.Extensions.DependencyInjection;
using TaskAssignment.CrossCutting.Extensions;

namespace TaskAssignment.CrossCutting
{
    public static class IoCConfig
    {
        public static void ConfigureDependencyInjection(this IServiceCollection service)
        {
            service.AddServices();
            service.AddRepositories();
        }
    }
}
