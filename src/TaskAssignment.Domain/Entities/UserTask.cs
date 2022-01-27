using TaskAssignment.Domain.Validations;

namespace TaskAssignment.Domain.Entities
{
    public class UserTask
    {
        public int Id { get; init; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public int UserId { get; set; }

        public decimal Estimate { get; set; }

        private UserTaskValidator Validator => new UserTaskValidator();

        public bool IsValid() => Validator.Validate(this).IsValid;

        public IEnumerable<string> ErrorMessages => Validator.Validate(this).Errors.Select(error => error.ErrorMessage);
    }
}
