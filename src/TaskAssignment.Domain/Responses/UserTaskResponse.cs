using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAssignment.Domain.Entities;

namespace TaskAssignment.Domain.Responses
{
    public record UserTaskResponse
    {
        public int Id { get; init; }

        public string? Title { get; init; }

        public string? Description { get; init; }

        public int UserId { get; init; }

        public decimal Estimate { get; init; }

        public static UserTaskResponse From(UserTask userTask) => new()
        {
            Id = userTask.Id,
            Title = userTask.Title,
            Description = userTask.Description,
            UserId = userTask.UserId,
            Estimate = userTask.Estimate,
        };
    }
}
