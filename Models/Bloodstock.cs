using System;
using System.Collections.Generic;

#nullable disable

namespace BBMS.Models
{
    public partial class Bloodstock
    {
        public Bloodstock()
        {
            Requests = new HashSet<Request>();
        }

        public int StockId { get; set; }
        public string BloodGroup { get; set; }
        public decimal? PricePerBag { get; set; }
        public string Status { get; set; }
        public int? BagQuantity { get; set; }

        public virtual ICollection<Request> Requests { get; set; }
    }
}
