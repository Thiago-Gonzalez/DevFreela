using DevFreela.Application.Commands.CreateProject;
using FluentValidation;

namespace DevFreela.Application.Validators
{
    public class CreateProjectCommandValidator : AbstractValidator<CreateProjectCommand>
    {
        public CreateProjectCommandValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty()
                .NotNull()
                .MaximumLength(30)
                .WithMessage("Tamanho máximo do Título é de 30 caracteres.");

            RuleFor(p => p.Description)
                .NotEmpty()
                .NotNull()
                .MaximumLength(255)
                .WithMessage("Tamanho máximo da Descrição é de 255 caracteres.");
        }
    }
}
