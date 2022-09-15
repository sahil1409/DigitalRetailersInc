using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DigitalRetailersInc.Models
{
    public class LaptopDetail
    {
        public int laptop_id { get; set; }
        [Required(ErrorMessage = "Laptop Name is Required")]
        [StringLength(100, ErrorMessage = "Minimum 3 and Maximum 100 characters are allowed", MinimumLength = 3)]
        public string laptop_name { get; set; }
        public Nullable<bool> is_active { get; set; }
        public Nullable<bool> is_delete { get; set; }
        public string laptop_image { get; set; }
        [Required]
        [Range(typeof(int), "1", "500", ErrorMessage = "Invalid Quantity")]
        public Nullable<int> quantity { get; set; }
        [Required]
        [Range(typeof(decimal), "1", "500000", ErrorMessage = "Invalid Price")]
        public Nullable<decimal> price { get; set; }
    }
}