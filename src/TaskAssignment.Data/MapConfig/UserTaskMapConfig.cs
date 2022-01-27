using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskAssignment.Domain.Entities;

namespace TaskAssignment.Data.MapConfig
{
    public class UserTaskMapConfig : IEntityTypeConfiguration<UserTask>
    {
        public void Configure(EntityTypeBuilder<UserTask> builder)
        {
            builder
                .HasKey(user => user.Id);

            builder
                .Property(user => user.Title)
                .HasDefaultValue("")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .Property(user => user.Description)
                .HasDefaultValue("")
                .HasMaxLength(200)
                .IsRequired();

            builder
                .Property(user => user.Estimate)
                .HasDefaultValue(0)
                .HasMaxLength(1)
                .IsRequired();
        }
    }
}
