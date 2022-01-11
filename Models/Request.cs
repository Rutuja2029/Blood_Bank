using System;
using System.Collections.Generic;

#nullable disable

namespace BBMS.Models
{
    public partial class Request
    {
        public int RequestId { get; set; }
        public DateTime? RequestDate { get; set; }
        public int? HospitalId { get; set; }
        public int? RequiredQuantity { get; set; }
        public int? StockId { get; set; }
        public string Status { get; set; }
        public decimal? AmountToPay { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public virtual Hospital Hospital { get; set; }
        public virtual Bloodstock Stock { get; set; }
    }
}
