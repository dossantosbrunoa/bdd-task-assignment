using Microsoft.Extensions.DependencyInjection;
using TaskAssignment.Data.Configuration;
using TaskAssignment.Data.Repositories;
using TaskAssignment.Domain.Repositories.Interfaces;

namespace TaskAssignment.CrossCutting.Extensions
{
    public static class RepositoriesConfig
    {
        public static void AddRepositories(this IServiceCollection service) 
        {
            service.AddScoped<IUsersRepository, UsersRepository>();
            service.AddScoped<IUserTasksRepository, UserTasksRepository>();
            service.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}