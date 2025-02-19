using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeSpace.Shared.Models.Request
{
    public class AddCommandToFunctionRequest
    {
        public string CommandId { get; set; }

        public string FunctionId { get; set; }
    }
}
