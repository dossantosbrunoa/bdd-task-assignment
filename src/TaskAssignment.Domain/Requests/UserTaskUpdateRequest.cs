using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskAssignment.Domain.Requests
{
    public record UserTaskUpdateRequest
    {
        public int Id { get; init; }
        public string? Title { get; init; }

        public string? Description { get; init; }

        public int UserId { get; init; }

        public decimal Estimate { get; init; }
    }
}
