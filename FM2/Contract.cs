//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FM2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contract
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public int PerWeek { get; set; }
        public int PerWeekWithBonus { get; set; }
    
        public virtual Player Player { get; set; }
    }
}
