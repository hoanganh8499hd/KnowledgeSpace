using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeSpace.Shared.Contracts.Domains.Interfaces
{
    public interface IEntityBase<T>
    {
        T Id { get; set; }
    }
}
