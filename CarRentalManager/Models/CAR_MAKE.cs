//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRentalManager.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAR_MAKE
    {
        public CAR_MAKE()
        {
            this.CARs = new HashSet<CAR>();
        }
    
        public int CAR_MAKE_ID { get; set; }
        public string CAR_MAKE1 { get; set; }
    
        public virtual ICollection<CAR> CARs { get; set; }
    }
}