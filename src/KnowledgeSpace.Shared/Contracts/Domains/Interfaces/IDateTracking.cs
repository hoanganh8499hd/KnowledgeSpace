using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeSpace.Shared.Contracts.Domains.Interfaces
{
    public interface IDateTracking
    {
        DateTime CreateDate { get; set; }
        DateTime? LastModifiedDate { get; set; }
    }
}
