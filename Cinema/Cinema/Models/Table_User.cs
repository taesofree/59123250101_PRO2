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
    
    public partial class Table_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Table_User()
        {
            this.Table_Order = new HashSet<Table_Order>();
        }
    
        public string U_EmailID { get; set; }
        public string U_Password { get; set; }
        public string U_Name { get; set; }
        public string U_LastName { get; set; }
        public string U_CardID { get; set; }
        public string U_Phone { get; set; }
        public Nullable<int> U_TypeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Table_Order> Table_Order { get; set; }
        public virtual Table_Type Table_Type { get; set; }
    }
}
