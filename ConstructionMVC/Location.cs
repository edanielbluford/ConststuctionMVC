//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConstructionMVC
{
    using System;
    using System.Collections.Generic;
    
    public partial class Location
    {
        public int LocationID { get; set; }
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public Nullable<int> HouseID { get; set; }
    
        public virtual House House { get; set; }
        public virtual House House1 { get; set; }
    }
}
