using System;
using TaskAssignment.Domain.Entities;

namespace TaskAssignment.Domain.Repositories.Interfaces
{
    public interface IUsersRepository
    {
        Task<IEnumerable<User>> GetAll();

        Task<User?> GetById(int id);
    }
}
