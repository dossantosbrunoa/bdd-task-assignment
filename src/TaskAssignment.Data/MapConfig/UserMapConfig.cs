using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskAssignment.Domain.Entities;

namespace TaskAssignment.Data.MapConfig
{
    public class UserMapConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasKey(user => user.Id);

            builder
                .Property(user => user.Id)
                .HasIdentityOptions(startValue: 1)
                .ValueGeneratedOnAdd()
                .HasColumnOrder(0);

            builder
                .Property(user => user.Email)
                .HasMaxLength(100);

            builder
                .Property(user => user.Name)
                .HasDefaultValue("")
                .HasMaxLength(100)
                .IsRequired();

            builder
                .HasMany(b => b.UserTasks)
                .WithOne();

            builder
                .Navigation(b => b.UserTasks)
                .UsePropertyAccessMode(PropertyAccessMode.Property);

            builder.HasData(
                new User(1, "João", "joao@email.com"),
                new User(2, "Maria", "maria@email.com"));
        }
    }
}
