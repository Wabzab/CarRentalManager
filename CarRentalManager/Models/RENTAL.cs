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
    
    public partial class RENTAL
    {
        public int RENTAL_NO { get; set; }
        public string CAR_NO { get; set; }
        public string DRIVER_NO { get; set; }
        public string INSPECTOR_NO { get; set; }
        public Nullable<int> RENTAL_FEE { get; set; }
        public Nullable<System.DateTime> STRT_DATE { get; set; }
        public Nullable<System.DateTime> ED_DATE { get; set; }
    
        public virtual CAR CAR { get; set; }
        public virtual DRIVER DRIVER { get; set; }
        public virtual INSPECTOR INSPECTOR { get; set; }
        public virtual RETURN RETURN { get; set; }
    }
}
