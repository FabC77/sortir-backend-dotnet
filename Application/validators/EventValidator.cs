﻿using Domain.models.entities;
using FluentValidation;

namespace Application.validators
{
    public class EventValidator : AbstractValidator<Event>
    {
        public EventValidator() 
        {
            RuleFor(e => e.Id).NotNull().WithMessage("L'ID ne peut être null.")
                                             .NotEmpty().WithMessage("L'ID ne peut être vide.");

            RuleFor(e => e.Name).NotNull().WithMessage("Le libellé est obligatoire.")
                                        .NotEmpty().WithMessage("Le libellé ne doit pas être vide.");

            RuleFor(e => e.Location).NotNull().WithMessage("Le lieu est obligatoire.")
                                        .NotEmpty().WithMessage("Le lieu ne doit pas être vide.");

            RuleFor(e => e.StartDate).NotNull()
                                            .GreaterThanOrEqualTo(DateTime.Now).WithMessage("La date de  Début ne doit pas être antérieure à la date du jour.")
                                            .LessThanOrEqualTo(e => e.Deadline).WithMessage("La date de début ne doit pas être ultérieure à la date de fin.");

            RuleFor(e => e.Deadline).NotNull()
                                            .GreaterThanOrEqualTo(DateTime.Now).WithMessage("La date de  Début ne doit pas être antérieure à la date du jour.")
                                            .GreaterThanOrEqualTo(e => e.StartDate).WithMessage("La date de fin ne doit pas être antérieure à la date de début.");

            RuleFor(e => e.StatusId).NotNull().WithMessage("L'état est obligatoire.")
                                        .NotEmpty().WithMessage("L'état ne doit pas être vide.");

            RuleFor(e => e.OrganizerId).NotNull().WithMessage("L'organisateur est obligatoire.")
                                        .NotEmpty().WithMessage("L'organisateur ne doit pas être vide.");

        }
    }
}
