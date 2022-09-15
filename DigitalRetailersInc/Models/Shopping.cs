using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DigitalRetailersInc.Models
{
    public class ShippingDetail
    {
        public int shipping_detail_id { get; set; }
        [Required]
        public Nullable<int> member_id { get; set; }
        [Required]
        public string adress { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public string state_is { get; set; }
        [Required]
        public string country { get; set; }
        [Required]
        public string zipcode { get; set; }
        public Nullable<int> order_id { get; set; }
        public string amount_paid { get; set; }
    }
}