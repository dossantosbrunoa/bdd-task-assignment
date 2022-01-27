namespace TaskAssignment.Domain.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        Task BeginTransactionAsync();

        Task CommitAsync();

        Task RollbackAsync();
    }
}
