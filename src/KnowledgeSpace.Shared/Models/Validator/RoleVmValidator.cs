﻿using FluentValidation;
using KnowledgeSpace.Shared.Models.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeSpace.Shared.Models.Validator
{
    public class RoleVmValidator : AbstractValidator<RoleCreateRequest>
    {
        public RoleVmValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id value is required")
                .MaximumLength(50).WithMessage("Role id cannot over limit 50 characters");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Role name is required");
        }
    }
}
