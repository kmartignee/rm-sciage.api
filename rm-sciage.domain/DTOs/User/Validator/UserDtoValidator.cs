using FluentValidation;

namespace rm_sciage.domain.DTOs.User.Validator;

public class UserDtoValidator : AbstractValidator<UserDto>
{
    public UserDtoValidator()
    {
        RuleFor(x => x.FirstName)
            .NotEmpty().WithMessage("Le prénom est requis");

        RuleFor(x => x.LastName)
            .NotEmpty().WithMessage("Le nom est requis");

        RuleFor(x => x.Email)
            .NotEmpty().WithMessage("L'email est requis");
        
        RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Le mot de passe est requis")
            .MinimumLength(6).WithMessage("Le mot de passe doit contenir au moins 6 caractères");
        
        RuleFor(x => x.Phone)
            .NotEmpty().WithMessage("Le téléphone est requis");
        
        RuleFor(x => x.BirthDate)
            .NotNull().WithMessage("La date de naissance est requise");
        
        RuleFor(x => x.Skills.Count)
            .Must(x => x > 0).WithMessage("Au moins une compétence est requise");
        
        RuleFor(x => x.IsAdmin)
            .NotNull().WithMessage("Le rôle est requis");
    }
}