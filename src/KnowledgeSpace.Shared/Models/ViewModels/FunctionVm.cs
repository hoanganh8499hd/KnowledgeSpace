﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeSpace.Shared.Models.ViewModels
{
    public class FunctionVm
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public int SortOrder { get; set; }

        public string ParentId { get; set; }

        public string Icon { get; set; }
    }
}
