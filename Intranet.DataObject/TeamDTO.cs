﻿using System;
using System.Collections.Generic;

namespace Intranet.DataObject
{
    public class TeamDTO : BaseDTO
    {
        public string TeamName { get; set; }
        public string? Clients { get; set; } = String.Empty;
        public string? About { get; set; } = String.Empty;
        public bool Company { get; set; }
        public int TechLead { get; set; }
    }

    public class TeamWithMemberDTO : TeamDTO
    {
        public IEnumerable<UserDTO> Members { get; set; }
    }
}
