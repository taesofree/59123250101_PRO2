//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cinema.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table_DetailOder
    {
        public int D_DetailOderID { get; set; }
        public Nullable<int> D_Order { get; set; }
        public Nullable<int> D_hairID { get; set; }
    
        public virtual Table_Chair Table_Chair { get; set; }
        public virtual Table_Order Table_Order { get; set; }
    }
}