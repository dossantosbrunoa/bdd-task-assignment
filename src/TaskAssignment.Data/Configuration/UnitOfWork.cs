using Microsoft.EntityFrameworkCore.Storage;
using TaskAssignment.Domain.Repositories.Interfaces;

namespace TaskAssignment.Data.Configuration
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;
        private IDbContextTransaction? _transaction;

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task BeginTransactionAsync()
        {
            if(_transaction != null)
            {
                return;
            }

            _transaction = await _appDbContext.Database.BeginTransactionAsync();
        }

        public async Task CommitAsync()
        {
            if(_transaction != null)
            {
                await _appDbContext.SaveChangesAsync();
                await _transaction.CommitAsync();
            }
        }

        public async Task RollbackAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
            }
        }
    }
}
