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
    
    public partial class View_SumOder
    {
        public int O_OrderID { get; set; }
        public int B_SatatusBayID { get; set; }
        public string B_Name { get; set; }
        public string U_EmailID { get; set; }
        public string U_Name { get; set; }
        public string U_LastName { get; set; }
        public string O_Email { get; set; }
        public byte[] O_IMGPAY { get; set; }
        public Nullable<int> O_Total { get; set; }
        public Nullable<int> O_SatatusBay { get; set; }
        public string O_DateOder { get; set; }
    }
}
