using FluentValidation;

namespace rm_sciage.domain.DTOs.Pointing.Validator;

public class PointingDtoValidator : AbstractValidator<PointingDto>
{
    public PointingDtoValidator()
    {
        RuleFor(x => x.UserId)
            .NotEmpty().WithMessage("L'identifiant de l'utilisateur est obligatoire");
        
        RuleFor(x => x.SiteIds.Count)
            .GreaterThan(0).WithMessage("Au moins un chantier doit être sélectionné");
        
        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("La description est obligatoire")
            .MaximumLength(100).WithMessage("La description ne doit pas dépasser 100 caractères");
        
        RuleFor(x => x.Clockings.Count)
            .GreaterThan(0).WithMessage("Au moins une déclaration de temps est obligatoire");

        RuleForEach(x => x.Clockings)
            .SetValidator(new ClockingDtoValidator());
    }
}