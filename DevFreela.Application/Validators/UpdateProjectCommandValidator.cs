using DevFreela.Application.Commands.UpdateProject;
using FluentValidation;

namespace DevFreela.Application.Validators
{
    public class UpdateProjectCommandValidator : AbstractValidator<UpdateProjectCommand>
    {
        public UpdateProjectCommandValidator()
        {
            RuleFor(p => p.Title)
                .NotEmpty()
                .NotNull()
                .MaximumLength(30)
                .WithMessage("Tamanho máximo para o Título é de 30 caracteres.");

            RuleFor(p => p.Description)
                .NotEmpty()
                .NotNull()
                .MaximumLength(255)
                .WithMessage("Tamanho máximo da Descrição é de 255 caracteres.");
        }
    }
}
