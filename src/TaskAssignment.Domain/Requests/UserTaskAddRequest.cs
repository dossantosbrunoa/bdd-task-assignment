namespace TaskAssignment.Domain.Requests
{
    public record UserTaskAddRequest
    {
        public string? Title { get; init; }

        public string? Description { get; init; }

        public int UserId { get; init; }

        public decimal Estimate { get; init; }
    }
}
