//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DigitalRetailersInc.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class shipping_details
    {
        public int shipping_detail_id { get; set; }
        public Nullable<int> member_id { get; set; }
        public string adress { get; set; }
        public string city { get; set; }
        public string state_is { get; set; }
        public string country { get; set; }
        public string zipcode { get; set; }
        public Nullable<int> order_id { get; set; }
        public string amount_paid { get; set; }
    
        public virtual member member { get; set; }
    }
}