﻿using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using KnowledgeSpace.Shared.Models.Request;


namespace KnowledgeSpace.Shared.Models.Validator
{
    public class UserCreateRequestValidator : AbstractValidator<UserCreateRequest>
    {
        public UserCreateRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("User name is required");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required");

            RuleFor(x => x.Email).NotEmpty().WithMessage("Email is required")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").WithMessage("Email format is not match");

            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Phone number is required");

            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name is required")
                .MaximumLength(50).WithMessage("First name can not over 50 characters limit");

            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name is required")
                .MaximumLength(50).WithMessage("Last name can not over 50 characters limit");
        }
    }
}
