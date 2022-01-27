using Microsoft.Extensions.DependencyInjection;
using TaskAssignment.Common.ErrorMessages;
using TaskAssignment.Common.ErrorMessages.Interface;
using TaskAssignment.Domain.Services;
using TaskAssignment.Domain.Services.Interfaces;

namespace TaskAssignment.CrossCutting.Extensions
{
    public static class ServicesConfig
    {
        public static void AddServices(this IServiceCollection service)
        {
            service.AddScoped<IUserTaskService, UserTaskService>();
            service.AddScoped<IErrorMessageService, ErrorMessageService>();
        }
    }
}
