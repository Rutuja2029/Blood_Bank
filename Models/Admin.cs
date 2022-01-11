using System;
using System.Collections.Generic;

#nullable disable

namespace BBMS.Models
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminEmail { get; set; }
        public string AdminPassword { get; set; }
        public string IsActive { get; set; }
    }
}
