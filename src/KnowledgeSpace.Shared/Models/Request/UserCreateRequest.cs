﻿using System;
using System.Collections.Generic;
using System.Text;

namespace KnowledgeSpace.Shared.Models.Request
{
    public class UserCreateRequest
    {
        public string UserName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Dob { get; set; }
    }
}
