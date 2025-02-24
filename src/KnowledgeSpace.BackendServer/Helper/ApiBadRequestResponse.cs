﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System;
using System.Linq;

namespace KnowledgeSpace.BackendServer.Helper
{
    public class ApiBadRequestResponse : ApiResponse
    {
        public IEnumerable<string> Errors { get; }

        public ApiBadRequestResponse(ModelStateDictionary modelState)
            : base(400)
        {
            if (modelState.IsValid)
            {
                throw new ArgumentException("ModelState must be invalid", nameof(modelState));
            }

            Errors = modelState.SelectMany(x => x.Value.Errors)
                .Select(x => x.ErrorMessage).ToArray();
        }

        public ApiBadRequestResponse(string message)
           : base(400, message)
        {
        }
    }
}
