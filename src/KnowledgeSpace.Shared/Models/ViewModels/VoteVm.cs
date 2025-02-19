using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeSpace.Shared.Models.ViewModels
{
    public class VoteVm
    {
        public int KnowledgeBaseId { get; set; }
        public string UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
