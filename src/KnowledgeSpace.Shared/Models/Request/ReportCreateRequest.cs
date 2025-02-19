﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeSpace.Shared.Models.Request
{
    public class ReportCreateRequest
    {
        public int? KnowledgeBaseId { get; set; }
        public int? CommentId { get; set; }
        public string Content { get; set; }
        public string ReportUserId { get; set; }
    }
}
