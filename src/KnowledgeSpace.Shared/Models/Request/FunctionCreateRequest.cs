using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeSpace.Shared.Models.Request
{
    public class FunctionCreateRequest
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public int SortOrder { get; set; }

        public string ParentId { get; set; }
    }
}
