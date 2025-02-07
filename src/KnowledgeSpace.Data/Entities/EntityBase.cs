using KnowledgeSpace.Shared.Contracts.Domains.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KnowledgeSpace.Persistence.Entities
{
    public abstract class EntityBase<T> : IEntityBase<T>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
    }
}
