using TaskAssignment.Domain.Entities;

namespace TaskAssignment.Domain.Responses
{
    public record UserResponse
    {
        public int Id { get; init; }

        public string? Name { get; init; }

        public string? Email { get; init; }

        public static UserResponse From(User user) => new()
        {
            Id = user.Id,
            Name = user.Name,
            Email = user.Email,
        };
    }
}
