using FluentValidation;

namespace rm_sciage.domain.DTOs.Pointing.Validator;

public class ClockingDtoValidator : AbstractValidator<ClockingDto>
{
    public ClockingDtoValidator()
    {
        RuleFor(x => x.IsAm)
            .NotNull().WithMessage("Le champ 'Matin' ou 'Après-midi' est obligatoire");
        
        RuleFor(x => x.ArrivalTime)
            .NotEmpty().WithMessage("L'heure d'arrivée est obligatoire")
            .NotNull().WithMessage("L'heure d'arrivée est obligatoire");
        
        RuleFor(x => x.DepartureTime)
            .NotEmpty().WithMessage("L'heure de départ est obligatoire")
            .NotNull().WithMessage("L'heure de départ est obligatoire");
    }
}