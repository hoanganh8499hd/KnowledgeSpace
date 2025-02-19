using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeSpace.Shared.Models.Request
{
    public class VoteCreateRequest
    {
        public int KnowledgeBaseId { get; set; }
        public string UserId { get; set; }
    }
}
