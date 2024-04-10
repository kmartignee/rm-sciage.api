using FluentValidation;

namespace rm_sciage.domain.DTOs.Site.Validator;

public class SiteDtoValidator : AbstractValidator<SiteDto>
{
    public SiteDtoValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage("Le nom est requis")
            .MaximumLength(50).WithMessage("Le nom ne doit pas dépasser 50 caractères");
        
        RuleFor(x => x.Description)
            .NotEmpty().WithMessage("La description est requise")
            .MaximumLength(100).WithMessage("La description ne doit pas dépasser 100 caractères");

        RuleFor(x => x.Address)
            .NotEmpty().WithMessage("L'adresse est requise")
            .MaximumLength(100).WithMessage("L'adresse ne doit pas dépasser 100 caractères");

        RuleFor(x => x.City)
            .NotEmpty().WithMessage("La ville est requise")
            .MaximumLength(50).WithMessage("La ville ne doit pas dépasser 50 caractères");

        RuleFor(x => x.ZipCode)
            .NotEmpty().WithMessage("Le code postal est requis")
            .GreaterThan(9999).WithMessage("Le code postal doit contenir 5 chiffres")
            .LessThan(100000).WithMessage("Le code postal doit contenir 5 chiffres");

        RuleFor(x => x.Status)
            .NotEmpty().WithMessage("Le statut est requis");
    }
}