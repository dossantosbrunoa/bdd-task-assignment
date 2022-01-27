using TaskAssignment.Domain.Entities;
using TaskAssignment.Domain.Requests;

namespace TaskAssignment.Domain.Services.Interfaces
{
    public interface IUserTaskService
    {
        Task<int?> Add(UserTaskAddRequest userTaskAddRequest);
        Task<UserTask?> Update(UserTaskUpdateRequest userTaskUpdateRequest);
    }
}
