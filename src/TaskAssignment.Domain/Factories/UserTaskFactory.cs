using TaskAssignment.Domain.Entities;
using TaskAssignment.Domain.Requests;

namespace TaskAssignment.Domain.Factories
{
    public static class UserTaskFactory
    {
        public static UserTask FromUserTaskRequest(UserTaskAddRequest userTaskAddRequest)
        {
            return new()
            {
                Title = userTaskAddRequest.Title,
                Description = userTaskAddRequest.Description,
                UserId = userTaskAddRequest.UserId,
                Estimate = userTaskAddRequest.Estimate,
            };
        }

        public static UserTask FromUserTaskRequest(UserTaskUpdateRequest userTaskUpdateRequest)
        {
            return new()
            {
                Id = userTaskUpdateRequest.Id,
                Title = userTaskUpdateRequest.Title,
                Description = userTaskUpdateRequest.Description,
                UserId = userTaskUpdateRequest.UserId,
                Estimate = userTaskUpdateRequest.Estimate,
            };
        }
    }
}
