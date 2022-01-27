using FluentValidation;
using TaskAssignment.Domain.Entities;

namespace TaskAssignment.Domain.Validations
{
    public class UserTaskValidator : AbstractValidator<UserTask>
    {
        public UserTaskValidator()
        {
            RuleFor(userTask => userTask.Title)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Task should have a title")
                .Length(2, 50).WithMessage("Length ({TotalLength}) of title is invalid");

            RuleFor(userTask => userTask.Description)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("Task should have a description")
                .Length(2, 200).WithMessage("Length ({TotalLength}) of description is Invalid");

            RuleFor(userTask => userTask.Estimate)
                .Cascade(CascadeMode.Stop)
                .InclusiveBetween(0.1m, 1.0m).WithMessage("Estimation should be between 0 and 1");
        }
    }
}
