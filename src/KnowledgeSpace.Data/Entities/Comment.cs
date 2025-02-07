using KnowledgeSpace.Shared.Contracts.Domains.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KnowledgeSpace.Persistence.Entities
{
    [Table("Comments")]
    public class Comment : EntityBase<int>, IDateTracking
    {
        [MaxLength(500)]
        [Required]
        public string Content { get; set; }

        [Required]
        [Range(1, Double.PositiveInfinity)]
        public int KnowledgeBaseId { get; set; }

        [MaxLength(50)]
        [Column(TypeName = "varchar(50)")]
        public string OwnwerUserId { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
