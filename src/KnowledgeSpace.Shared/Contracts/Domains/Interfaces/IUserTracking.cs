using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeSpace.Shared.Contracts.Domains.Interfaces
{
    public interface IUserTracking
    {
        string CreateBy { get; set; }
        string LastModifiedBy { get; set; }
    }
}
