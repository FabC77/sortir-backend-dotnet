using Domain.models.entities;
using FluentValidation;

namespace Application.validators
{
    public class SortieValidator : AbstractValidator<Sortie>
    {
        public SortieValidator() 
        {
            RuleFor(sortie => sortie.Id).NotNull().WithMessage("L'ID ne peut être null.")
                                             .NotEmpty().WithMessage("L'ID ne peut être vide.");

            RuleFor(sortie => sortie.Libelle).NotNull().WithMessage("Le libellé est obligatoire.")
                                        .NotEmpty().WithMessage("Le libellé ne doit pas être vide.");

            RuleFor(sortie => sortie.Lieu).NotNull().WithMessage("Le lieu est obligatoire.")
                                        .NotEmpty().WithMessage("Le lieu ne doit pas être vide.");

            RuleFor(sortie => sortie.DateDeb).NotNull()
                                            .GreaterThanOrEqualTo(DateTime.Now).WithMessage("La date de  Début ne doit pas être antérieure à la date du jour.")
                                            .LessThanOrEqualTo(sortie => sortie.DateFin).WithMessage("La date de début ne doit pas être ultérieure à la date de fin.");

            RuleFor(sortie => sortie.DateFin).NotNull()
                                            .GreaterThanOrEqualTo(DateTime.Now).WithMessage("La date de  Début ne doit pas être antérieure à la date du jour.")
                                            .GreaterThanOrEqualTo(sortie => sortie.DateDeb).WithMessage("La date de fin ne doit pas être antérieure à la date de début.");

            RuleFor(sortie => sortie.IdEtat).NotNull().WithMessage("L'état est obligatoire.")
                                        .NotEmpty().WithMessage("L'état ne doit pas être vide.");

            RuleFor(sortie => sortie.IdOrganisateur).NotNull().WithMessage("L'organisateur est obligatoire.")
                                        .NotEmpty().WithMessage("L'organisateur ne doit pas être vide.");

        }
    }
}
