using Microsoft.EntityFrameworkCore;
using TaskAssignment.Data.Configuration;
using TaskAssignment.Domain.Entities;
using TaskAssignment.Domain.Repositories.Interfaces;

namespace TaskAssignment.Data.Repositories
{
    public class UserTasksRepository : IUserTasksRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserTasksRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<UserTask> Add(UserTask userTask)
        {
            var createdUserTask = await _appDbContext.UserTask.AddAsync(userTask);
            return createdUserTask.Entity;
        }

        public async Task<UserTask?> GetById(int id)
        {
            return await _appDbContext.UserTask
                .AsNoTracking()
                .SingleOrDefaultAsync(ut => ut.Id == id);
        }

        public async Task<UserTask?> Update(UserTask userTask)
        {
            var updatedUserTask = await _appDbContext.UserTask.SingleOrDefaultAsync(ut => ut.Id == userTask.Id);
            if(updatedUserTask != null)
            {
                updatedUserTask.Title = userTask.Title;
                updatedUserTask.Description = userTask.Description;
                updatedUserTask.UserId = userTask.UserId;
                updatedUserTask.Estimate = userTask.Estimate;
            }
            return updatedUserTask;
        }
    }
}
