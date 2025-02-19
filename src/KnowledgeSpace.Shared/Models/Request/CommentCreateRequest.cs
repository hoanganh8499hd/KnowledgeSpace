using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeSpace.Shared.Models.Request
{
    public class CommentCreateRequest
    {
        public string Content { get; set; }
        public int KnowledgeBaseId { get; set; }
    }
}
