using FluentValidation;

namespace StudentManagementWebApi.Application.UserOperations.Commands.CreateUser
{
   public class CreateUserCommandValidator : AbstractValidator<CreateUserCommand>
   {
        public CreateUserCommandValidator()
        {
            RuleFor(command => command.Model.Name).NotEmpty().MinimumLength(4);
            RuleFor(command => command.Model.Surname).NotEmpty().MinimumLength(4);
            RuleFor(command => command.Model.Email).NotEmpty().MinimumLength(4);
            RuleFor(command => command.Model.Password).NotEmpty().MinimumLength(6);
        }
   }
}