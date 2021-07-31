using FluentValidation;
using MealyBT.Models;

namespace MealyBT.Validators
{
    public class TaskValidator: AbstractValidator<Task>
    {
        public TaskValidator()
        {
            RuleFor(t => t.Id).NotNull();
            RuleFor(t => t.Title).NotNull();
        }
    }
}