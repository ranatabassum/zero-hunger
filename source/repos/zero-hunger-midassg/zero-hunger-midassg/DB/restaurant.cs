//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace zero_hunger_midassg.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class restaurant
    {
        public int r_id { get; set; }
        public string r_name { get; set; }
        public string food_name { get; set; }
        public string availibility { get; set; }
        public System.DateTime expiryDate { get; set; }
        public string r_uname { get; set; }
        public string r_pass { get; set; }
        public Nullable<int> ngo_id { get; set; }
    
        public virtual NGO NGO { get; set; }
    }
}
