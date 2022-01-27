using TaskAssignment.Domain.Entities;

namespace TaskAssignment.Domain.Repositories.Interfaces
{
    public interface IUserTasksRepository
    {
        Task<UserTask> Add(UserTask userTask);
        Task<UserTask?> GetById(int id);
        Task<UserTask?> Update(UserTask userTask);
    }
}
