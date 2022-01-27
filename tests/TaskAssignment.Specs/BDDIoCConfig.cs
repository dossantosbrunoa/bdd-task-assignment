using Microsoft.Extensions.DependencyInjection;
using SolidToken.SpecFlow.DependencyInjection;
using TaskAssignment.CrossCutting;
using TaskAssignment.Data.Configuration;

namespace TaskAssignment.Specs
{
    public static class BDDIoCConfig
    {
        [ScenarioDependencies]
        public static IServiceCollection CreateServices()
        {
            var services = new ServiceCollection();

            services.ConfigureDependencyInjection();
            services.AddDbContext<AppDbContext>();

            return services;
        }
    }
}
