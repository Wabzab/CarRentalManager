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
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations;

    public partial class RETURN
    {
        public int RENTAL_NO { get; set; }

        public System.DateTime RETURNED_DATE { get; set; }

        [ScaffoldColumn(false)]
        public Nullable<int> ELAPSED_TIME { get; set; }

        [ScaffoldColumn(false)]
        public Nullable<int> FINE { get; set; }
    
        public virtual RENTAL RENTAL { get; set; }
    }
}
