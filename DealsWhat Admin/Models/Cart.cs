//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DealsWhat_Admin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public System.Guid Id { get; set; }
        public int Quantity { get; set; }
        public Nullable<int> User_UserId { get; set; }
        public Nullable<System.Guid> Deal_Id { get; set; }
    
        public virtual Deal Deal { get; set; }
        public virtual User User { get; set; }
    }
}
