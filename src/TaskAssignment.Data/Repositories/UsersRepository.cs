using Microsoft.EntityFrameworkCore;
using TaskAssignment.Data.Configuration;
using TaskAssignment.Domain.Entities;
using TaskAssignment.Domain.Repositories.Interfaces;

namespace TaskAssignment.Data.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly AppDbContext _appDbContext;

        public UsersRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _appDbContext.User.ToListAsync();
        }

        public async Task<User?> GetById(int id)
        {
            return await _appDbContext.User
                .AsNoTracking()
                .SingleOrDefaultAsync(u => u.Id == id);
        }
    }
}
