﻿using FluentValidation;
using KnowledgeSpace.Shared.Models.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeSpace.Shared.Models.Validator
{
    public class CommentCreateRequestValidator : AbstractValidator<CommentCreateRequest>
    {
        public CommentCreateRequestValidator()
        {
            RuleFor(x => x.KnowledgeBaseId).GreaterThan(0)
                .WithMessage("Knowledge base Id is not valid");

            RuleFor(x => x.Content).NotEmpty().WithMessage("Content is required");
        }
    }
}
