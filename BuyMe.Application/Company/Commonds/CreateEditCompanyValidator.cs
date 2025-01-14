﻿using FluentValidation;

namespace BuyMe.Application.Company.Commonds
{
    public class CreateEditCompanyValidator : AbstractValidator<CreateEditCompanyCommond>
    {
        public CreateEditCompanyValidator()
        {
            RuleFor(d => d.Name).NotEmpty();
            RuleFor(d => d.Country).NotEmpty();
            RuleFor(d => d.City).NotEmpty();
            RuleFor(d => d.Telephone).NotEmpty();
        }
    }
}