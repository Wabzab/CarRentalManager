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
    
    public partial class INSPECTOR
    {
        public INSPECTOR()
        {
            this.RENTALs = new HashSet<RENTAL>();
        }
    
        public string INSPECTOR_NO { get; set; }
        public string INSPECTOR_NAME { get; set; }
        public string EMAIL { get; set; }
        public string MOBILE { get; set; }
    
        public virtual ICollection<RENTAL> RENTALs { get; set; }
    }
}