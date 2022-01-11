using System;
using System.Collections.Generic;

#nullable disable

namespace BBMS.Models
{
    public partial class Hospital
    {
        public Hospital()
        {
            Requests = new HashSet<Request>();
        }

        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public string Address { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual ICollection<Request> Requests { get; set; }
    }
}
